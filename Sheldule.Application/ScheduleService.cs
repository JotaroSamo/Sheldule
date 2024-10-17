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
        public async Task SaveScheduleReport(string filePath)
        {
            try
            {
                var _schedules = await GetList();

                // Создаем PDF-документ
                using (PdfDocument document = new PdfDocument())
                {
                    document.Info.Title = "Отчет о расписании";

                    // Добавляем страницу
                    PdfPage page = document.AddPage();
                    page.Size = PdfSharpCore.PageSize.A4;

                    // Создаем графический объект для рисования
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont fontTitle = new XFont("Times New Roman", 18, XFontStyle.Bold);
                    XFont fontHeader = new XFont("Times New Roman", 16, XFontStyle.Bold);
                    XFont fontText = new XFont("Times New Roman", 14, XFontStyle.Regular);

                    // Добавляем заголовок
                    gfx.DrawString("Отчет о расписании", fontTitle, XBrushes.Black, new XRect(0, 20, page.Width, 0), XStringFormats.TopCenter);

                    // Группировка расписания по группам
                    var groupedSchedules = _schedules.GroupBy(schedule => schedule.GroupId)
                                                      .ToDictionary(g => g.Key, g => g.ToList());

                    // Переменная для отслеживания текущей высоты рисования
                    double yPoint = 50;

                    // Создание отчета
                    foreach (var group in groupedSchedules)
                    {
                        var groupSchedules = group.Value;
                        var studentGroup = groupSchedules.First().Group; // Предполагаем, что все расписания имеют одну группу

                        // Добавляем название группы с градиентным фоном и округлением
                        DrawGradientRectangle(gfx, 20, yPoint, page.Width - 40, 30, XColors.LightGray, XColors.DarkGray);
                        gfx.DrawString($"Группа: {studentGroup.Name}", fontHeader, XBrushes.Black, new XRect(20, yPoint, page.Width - 40, 0), XStringFormats.TopLeft);
                        yPoint += 40; // Увеличиваем высоту для следующего блока

                        // Группировка по неделям
                        var groupedByWeeks = groupSchedules.GroupBy(schedule => schedule.Week.Number);
                        foreach (var week in groupedByWeeks)
                        {
                            gfx.DrawString($"Неделя: {week.Key}", fontHeader, XBrushes.Black, new XRect(20, yPoint, page.Width - 40, 0), XStringFormats.TopLeft);
                            yPoint += 20;

                            // Создаем таблицу для расписания
                            foreach (var schedule in week)
                            {
                                // Рисуем строку с округленным фоном
                                DrawGradientRectangle(gfx, 20, yPoint, page.Width - 40, 20, XColors.White, XColors.LightGray);

                                // Добавляем данные в строку с обработкой переполнения текста
                                gfx.DrawString(schedule.DayOfWeek.ToString(), fontText, XBrushes.Black, new XRect(20, yPoint, 100, 0), XStringFormats.TopLeft);
                                gfx.DrawString(schedule.Subject.Name, fontText, XBrushes.Black, new XRect(120, yPoint, 100, 0), XStringFormats.TopLeft);
                                gfx.DrawString(schedule.Teacher.Name, fontText, XBrushes.Black, new XRect(220, yPoint, 100, 0), XStringFormats.TopLeft);
                                gfx.DrawString(schedule.Classroom.Number, fontText, XBrushes.Black, new XRect(320, yPoint, 100, 0), XStringFormats.TopLeft);
                                gfx.DrawString(schedule.SubjectType.ToString(), fontText, XBrushes.Black, new XRect(420, yPoint, 100, 0), XStringFormats.TopLeft);

                                // Обработка переполнения текста для времени
                                string timeString = $"{schedule.ClassTime.StartTime:hh\\:mm}";
                                DrawStringWithWidthLimit(gfx, timeString, fontText, XBrushes.Black, 520, yPoint, 100);

                                yPoint += 20; // Увеличиваем высоту для следующей строки
                            }

                            yPoint += 10; // Отступ между неделями
                        }

                        yPoint += 20; // Отступ между группами
                    }

                    // Сохраняем документ в файл
                    document.Save(filePath);
                }
            }
            catch (Exception ex)
            {
                // Логирование или уведомление об ошибке
                Console.WriteLine($"Ошибка при сохранении отчета: {ex.Message}");
            }
        }


        // Метод для рисования градиента
        private void DrawGradientRectangle(XGraphics gfx, double x, double y, double width, double height, XColor color1, XColor color2)
        {
            XLinearGradientBrush brush = new XLinearGradientBrush(new XPoint(x, y), new XPoint(x, y + height), color1, color2);
            gfx.DrawRectangle(brush, x, y, width, height);
        }

        // Метод для рисования строки с ограничением по ширине
        private void DrawStringWithWidthLimit(XGraphics gfx, string text, XFont font, XBrush brush, double x, double y, double maxWidth)
        {
            // Разделение строки на слова
            string[] words = text.Split(' ');
            string line = string.Empty;
            double lineHeight = font.GetHeight();
            double currentY = y;

            foreach (var word in words)
            {
                string testLine = line + word + " ";
                double testWidth = gfx.MeasureString(testLine, font).Width;

                if (testWidth > maxWidth)
                {
                    gfx.DrawString(line, font, brush, new XRect(x, currentY, maxWidth, lineHeight), XStringFormats.TopLeft);
                    line = word + " ";
                    currentY += lineHeight; // Переход на следующую строку
                }
                else
                {
                    line = testLine;
                }
            }

            // Отрисовка последней линии
            gfx.DrawString(line, font, brush, new XRect(x, currentY, maxWidth, lineHeight), XStringFormats.TopLeft);
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
