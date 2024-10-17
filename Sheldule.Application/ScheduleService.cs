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
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;


namespace SheldulePro.Application
{
    public class ScheduleService : Repo<Schedule>
    {
        private readonly SchelduleContext _context = new SchelduleContext();

        public ScheduleService()
        {
           
        }
        public async Task GenerateReport(string filePath)
        {
            var schedules = await GetList();

            // Создаем новый PDF-документ
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Отчет по расписанию";

            // Создаем страницу
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromMillimeter(297); // ширина A4 в ландшафтной ориентации
            page.Height = XUnit.FromMillimeter(210); // высота A4

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Arial", 16, XFontStyle.Bold);
            XFont headerFont = new XFont("Arial", 12, XFontStyle.Bold);
            XFont contentFont = new XFont("Arial", 12, XFontStyle.Regular);

            // Заголовок
            gfx.DrawString("Отчет по расписанию", titleFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);

            // Установка начальной позиции для текста
            int yPos = 40;

            // Заголовки таблицы
            gfx.DrawRectangle(XBrushes.LightGray, new XRect(60, yPos, 700, 30)); // фон для заголовков
            gfx.DrawString("Группа", headerFont, XBrushes.Black, new XRect(60, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("Время", headerFont, XBrushes.Black, new XRect(160, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("Предмет", headerFont, XBrushes.Black, new XRect(260, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("Класс", headerFont, XBrushes.Black, new XRect(360, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("Учителя", headerFont, XBrushes.Black, new XRect(460, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("День недели", headerFont, XBrushes.Black, new XRect(560, yPos, 100, 20), XStringFormats.Center);
            gfx.DrawString("Неделя", headerFont, XBrushes.Black, new XRect(660, yPos, 100, 20), XStringFormats.Center);
            yPos += 30;

            // Добавляем данные расписания
            int rowCount = 0;
            foreach (var schedule in schedules.OrderBy(w=>w.Week.StartDate))
            {
                XBrush backgroundBrush = (rowCount % 2 == 0) ? XBrushes.LightSeaGreen : XBrushes.LightGreen; // Чередуем цвета

                // Рисуем прямоугольник для фона строки
                gfx.DrawRectangle(backgroundBrush, new XRect(60, yPos, 700, 20));

                gfx.DrawString(string.Join(", ", schedule.Group.Select(g => g.Name)), contentFont, XBrushes.Black, new XRect(60, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(schedule.ClassTime.Number.ToString() + " - " + schedule.ClassTime.StartTime.ToString(), contentFont, XBrushes.Black, new XRect(160, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(schedule.Subject?.Name ?? "Не указано", contentFont, XBrushes.Black, new XRect(260, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(schedule.Classroom?.Number ?? "Не указано", contentFont, XBrushes.Black, new XRect(360, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(string.Join(", ", schedule.Teacher.Select(t => t.Name)), contentFont, XBrushes.Black, new XRect(460, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(schedule.DayOfWeek.ToString(), contentFont, XBrushes.Black, new XRect(560, yPos, 100, 20), XStringFormats.Center);
                gfx.DrawString(schedule.Week.Number.ToString(), contentFont, XBrushes.Black, new XRect(660, yPos, 100, 20), XStringFormats.Center);
                yPos += 20;
                rowCount++;
                // Если места не хватает, добавляем новую страницу
                if (yPos > page.Height - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    yPos = 30; // Сброс позиции
                               // Рисуем заголовки на новой странице
                    gfx.DrawRectangle(XBrushes.LightGray, new XRect(60, yPos, 640, 30));
                    gfx.DrawString("Группа", headerFont, XBrushes.Black, new XRect(60, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("Время", headerFont, XBrushes.Black, new XRect(160, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("Предмет", headerFont, XBrushes.Black, new XRect(260, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("Класс", headerFont, XBrushes.Black, new XRect(360, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("Учителя", headerFont, XBrushes.Black, new XRect(460, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("День недели", headerFont, XBrushes.Black, new XRect(560, yPos, 100, 20), XStringFormats.Center);
                    gfx.DrawString("Неделя", headerFont, XBrushes.Black, new XRect(660, yPos, 100, 20), XStringFormats.Center); ;
                    yPos += 30;
                }
            }

            // Сохраняем PDF-документ
            document.Save(filePath);
        }






        public async Task<Result> CreateScheduleAsync(Schedule newSchedule)
        {
            var errors = new List<string>();

            // Проверка, занята ли хотя бы одна из групп в это время
            bool isGroupBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.WeekId == newSchedule.WeekId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.Group.Select(g => g.Id).Intersect(newSchedule.Group.Select(g => g.Id)).Any()); // Проверка пересечения групп

            if (isGroupBusy)
            {
                errors.Add("Одна или несколько групп уже заняты в это время.");
            }

            // Проверка, занят ли хотя бы один из преподавателей в это время
            bool isTeacherBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.WeekId == newSchedule.WeekId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.Teacher.Select(t => t.Id).Intersect(newSchedule.Teacher.Select(t => t.Id)).Any()); // Проверка пересечения преподавателей

            if (isTeacherBusy)
            {
                errors.Add("Один или несколько преподавателей уже заняты в это время.");
            }

            // Проверка, занят ли кабинет в это время
            bool isClassroomBusy = await _context.Schedules
                .AsQueryable()
                .AnyAsync(s =>
                    s.WeekId == newSchedule.WeekId &&
                    s.DayOfWeek == newSchedule.DayOfWeek &&
                    s.ClassTimeId == newSchedule.ClassTimeId &&
                    s.ClassroomId == newSchedule.ClassroomId);

            if (isClassroomBusy)
            {
                errors.Add("Кабинет уже занят в это время.");
            }

            // Если есть ошибки, возвращаем их
            if (errors.Any())
            {
                return Result.Failure(string.Join(", ", errors));
            }


            return Result.Success();
        }


       
        // Создание нового расписания
        public async Task<Schedule> Create(Schedule entity)
        {

             _context.Schedules.Attach(entity);
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
                schedule.Group = entity.Group;
                schedule.ClassTimeId = entity.ClassTimeId;
                schedule.SubjectId = entity.SubjectId;
                schedule.SubjectType = entity.SubjectType;
                schedule.Teacher = entity.Teacher;
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
            // Проверяем и загружаем группы
            var groupIds = entity.Group.Select(g => g.Id).ToList(); // Получаем список идентификаторов групп
            entity.Group = await _context.StudentGroups
                .Where(g => groupIds.Contains(g.Id)) // Загружаем группы по идентификаторам
                .ToListAsync();

            // Загрузка преподавателей
            var teacherIds = entity.Teacher.Select(t => t.Id).ToList(); // Получаем список идентификаторов преподавателей
            entity.Teacher = await _context.Teachers
                .Where(t => teacherIds.Contains(t.Id)) // Загружаем преподавателей по идентификаторам
                .ToListAsync();

            // Проверяем и загружаем остальные сущности
            entity.ClassTime = await _context.ClassTimes.FindAsync(entity.ClassTimeId);
            entity.Subject = await _context.Subjects.FindAsync(entity.SubjectId);
            entity.Week = await _context.Weeks.FindAsync(entity.WeekId);
            entity.Classroom = await _context.Classrooms.FindAsync(entity.ClassroomId);
        }

    }
}
