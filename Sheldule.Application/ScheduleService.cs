using Sheldule.Application.IService;
using Sheldule.DataAccess.Model;
using Sheldule.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CSharpFunctionalExtensions;

namespace SheldulePro.Application
{
    public class ScheduleService : Repo<Schedule>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public ScheduleService()
        {
           
        }
        public async Task<Result> CreateScheduleAsync(Schedule newSchedule)
        {
            var errors = new List<string>();

            // Проверка, занята ли группа в этот день и время
            bool isGroupBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.GroupId == newSchedule.GroupId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.WeekId == newSchedule.WeekId);

            if (isGroupBusy)
            {
                errors.Add("Группа уже занята в это время.");
            }

            // Проверка, занят ли преподаватель в этот день и время
            bool isTeacherBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.TeacherId == newSchedule.TeacherId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.WeekId == newSchedule.WeekId);

            if (isTeacherBusy)
            {
                errors.Add("Преподаватель уже занят в это время.");
            }

            // Проверка, занят ли кабинет в этот день и время
            bool isClassroomBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.ClassroomId == newSchedule.ClassroomId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.WeekId == newSchedule.WeekId);

            if (isClassroomBusy)
            {
                errors.Add("Кабинет уже занят в это время.");
            }

            // Если есть ошибки, возвращаем их
            if (errors.Any())
            {
                return Result.Failure(string.Join(", ", errors));
            }

            // Если ошибок нет, создаем запись
            return Result.Success();
        }

        public async Task<Schedule> Filter(int WeekId, string Day, int GroupId)
        {
            var sheldule = await _context.Schedules.
                Where(i => i.WeekId == WeekId && i.DayOfWeek.ToString() == Day && i.GroupId == GroupId)
                .FirstOrDefaultAsync();
            await LoadDependencies(sheldule);
            return sheldule;
        }
        // Создание нового расписания
        public async Task<Schedule> Create(Schedule entity)
        {
            // Убедитесь, что все внешние сущности существуют
            await LoadDependencies(entity);

            await _context.Schedules.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Удаление расписания
        public async Task Delete(Schedule entity)
        {
            var schedule = await _context.Schedules.FindAsync(entity.Id);
            if (schedule != null)
            {
                _context.Schedules.Remove(schedule);
                await _context.SaveChangesAsync();
            }
        }

        // Получение расписания по идентификатору
        public async Task<Schedule> GetById(Schedule entity)
        {
            return await _context.Schedules
                .Include(s => s.Group)
                .Include(s => s.ClassTime)
                .Include(s => s.Subject)
                .Include(s => s.Teacher)
                .Include(s => s.Week)
                 .Include(s => s.Classroom)
                .FirstOrDefaultAsync(s => s.Id == entity.Id);
        }

        // Получение списка всех расписаний
        public async Task<List<Schedule>> GetList()
        {
            return await _context.Schedules
                .Include(s => s.Group)
                .Include(s => s.ClassTime)
                .Include(s => s.Subject)
                .Include(s => s.Teacher)
                .Include(s => s.Week)
                .Include(s=>s.Classroom)
                .ToListAsync();
        }

        // Обновление существующего расписания
        public async Task<Schedule> Update(Schedule entity)
        {
            var schedule = await _context.Schedules.FindAsync(entity.Id);
            if (schedule != null)
            {
                // Обновление полей
                schedule.GroupId = entity.GroupId;
                schedule.ClassTimeId = entity.ClassTimeId;
                schedule.SubjectId = entity.SubjectId;
                schedule.SubjectType = entity.SubjectType;
                schedule.TeacherId = entity.TeacherId;
                schedule.DayOfWeek = entity.DayOfWeek;
                schedule.WeekId = entity.WeekId;

                // Убедитесь, что все внешние сущности существуют
                await LoadDependencies(schedule);

                await _context.SaveChangesAsync();
            }
            return schedule;
        }

        // Метод для проверки и загрузки зависимых сущностей
        private async Task LoadDependencies(Schedule entity)
        {
            // Проверяем, что все внешние сущности существуют
            entity.Group = await _context.StudentGroups.FindAsync(entity.GroupId);
            entity.ClassTime = await _context.ClassTimes.FindAsync(entity.ClassTimeId);
            entity.Subject = await _context.Subjects.FindAsync(entity.SubjectId);
            entity.Teacher = await _context.Teachers.FindAsync(entity.TeacherId);
            entity.Week = await _context.Weeks.FindAsync(entity.WeekId);
            entity.Classroom = await _context.Classrooms.FindAsync(entity.ClassroomId);

           
        }
    }
}
