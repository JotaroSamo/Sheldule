using Sheldule.Application.IService;
using Sheldule.DataAccess.Model;
using Sheldule.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SheldulePro.Application
{
    public class ScheduleService : Repo<Schedule>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public ScheduleService()
        {
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

           
        }
    }
}
