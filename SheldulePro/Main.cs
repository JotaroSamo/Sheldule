using Sheldule.Application;
using Sheldule.DataAccess.Enums;
using Sheldule.DataAccess.Model;
using SheldulePro.Application;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;

namespace SheldulePro
{
    public partial class Main : Form
    {
        private readonly StudentGroupService _studentGroupService = new StudentGroupService();
        private readonly ClassroomService _classroomService = new ClassroomService();
        private readonly SubjectService _subjectService = new SubjectService();
        private readonly TeacherService _teacherService = new TeacherService();
        private readonly ClassTimeService _timeService = new ClassTimeService();
        private readonly WeekService _weekService = new WeekService();
        private readonly ScheduleService _scheduleService = new ScheduleService();
        private int SelectScheduleId = 0;
        public Main()
        {
            InitializeComponent();

            toolStrip.BackColor = Color.FromArgb(50, 50, 50);
            Style.ApplyGlobalStyles(this.Controls);
            Style.ApplyFormBackground(this);
            LoadComboBoxesAsync();

        }
        public async Task LoadComboBoxesAsync()
        {
            // Запуск запросов параллельно
            var weekTask = _weekService.GetList();
            var groupTask = _studentGroupService.GetList();
            var timeTask = _timeService.GetList();
            var subjectTask = _subjectService.GetList();
            var teacherTask = _teacherService.GetList();
            var roomTask = _classroomService.GetList();

            // Ожидание завершения всех задач
            await Task.WhenAll(weekTask, groupTask, timeTask, subjectTask, teacherTask, roomTask);

            // Присваивание данных для ComboBox после завершения всех запросов
            WeekBox.DataSource = weekTask.Result;
            WeekBox.DisplayMember = "Number";
            WeekBox.ValueMember = "Id";

            
            GroupBox.DataSource = groupTask.Result;
            GroupBox.DisplayMember = "Name";
            GroupBox.ValueMember = "Id";

        
            TeachersBoxNew.DataSource = teacherTask.Result;
            TeachersBoxNew.DisplayMember = "Name";
            TeachersBoxNew.ValueMember = "Id";

            TimeBoxNew.DataSource = timeTask.Result
             .Select(t => new
             {
                 Id = t.Id,
                 Display = $"Пара {t.Number}: {t.StartTime} - {t.EndTime}" // Объединяем номер пары и время
             })
             .ToList();

            TimeBoxNew.DisplayMember = "Display"; // Поле с объединенным текстом
            TimeBoxNew.ValueMember = "Id"; // Поле для значения


            GroupBox.ValueMember = "Id";

            SubjectBoxNew.DataSource = subjectTask.Result;
            SubjectBoxNew.DisplayMember = "Name";
            SubjectBoxNew.ValueMember = "Id";

            TypeSubjectNewBox.DataSource = Enum.GetValues(typeof(SubjectType)); // Привязка enum
            DayBox.DataSource = Enum.GetValues(typeof(DayOfWeekEnum));
           

            RoomBoxNew.DataSource = roomTask.Result
                 .Select(r => new
                 {
                     Id = r.Id,
                     Display = $"{r.Number} ({r.Type})" // Объединяем номер и тип
                 })
                 .ToList();

            RoomBoxNew.DisplayMember = "Display"; // Поле с объединенным текстом
            RoomBoxNew.ValueMember = "Id"; // Поле для значения

        }


        #region toolbarbtn

        private async void toolReport_Click(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Формируем имя файла с текущей датой и временем
            var fileName = $"ScheduleReport_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.pdf";
            var filePath = Path.Combine(desktopPath, fileName);
            await _scheduleService.GenerateReport(filePath);
            MessageBox.Show("Отчет сохранен на рабочем столе.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void SubjectToolStrip_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm(this);
            subjectForm.ShowDialog();
            if (subjectForm.DialogResult == DialogResult.OK)
            {
                subjectForm.Close();
            }
        }

        private void TimeAndWeekBtn_Click(object sender, EventArgs e)
        {
            TimeAndWeekForm timeAndWeekForm = new TimeAndWeekForm(this);
            timeAndWeekForm.ShowDialog();
            if (timeAndWeekForm.DialogResult == DialogResult.OK)
            {
                timeAndWeekForm.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TeachersForms teachersForms = new TeachersForms(this);
            teachersForms.ShowDialog();
            if (teachersForms.DialogResult == DialogResult.OK)
            {
                teachersForms.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm(this);
            groupForm.ShowDialog();
            if (groupForm.DialogResult == DialogResult.OK)
            {
                groupForm.Close();
            }
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            ClassroomFrom classroomFrom = new ClassroomFrom(this);
            classroomFrom.ShowDialog();
            if (classroomFrom.DialogResult == DialogResult.OK)
            {
                classroomFrom.Close();
            }
        }
        #endregion

        private async void WeekBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroups = GroupBox.SelectedItems.Cast<StudentGroup>().Select(s => s.Id).ToList();
   
            // Обработка конвертации для WeekBox
            if (!int.TryParse(WeekBox.SelectedValue?.ToString(), out int selectedWeekId))
            {

                return;
            }

            // Обработка значения дня
            string selectDay = DayBox.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectDay))
            {

                return;
            }

            // Обработка конвертации для GroupBox
            if (selectedGroups is null)
            {

                return;
            }
           

            try
            {
                // Получаем список расписаний
                var schedules = await _scheduleService.GetList();

                // Фильтруем расписания по выбранной неделе, дню и группе
                var filteredSchedules = schedules
                    .Where(s => s.WeekId == selectedWeekId &&
                                s.DayOfWeek.ToString() == selectDay &&
                                s.Group.Any(g => selectedGroups.Contains(g.Id)))
                    .Select(s => new
                    {
                        Id = s.Id,
                        Группы = string.Join(", ", s.Group.Select(t => t.Name)),
                        Время = s.ClassTime.Number + " " + s.ClassTime.StartTime.ToString() + " - " + s.ClassTime.EndTime.ToString(),  // Время занятия
                        Предмет = s.Subject.Name,            // Предмет
                        Тип = s.SubjectType.ToString(),      // Тип предмета
                        Учитель = string.Join(", ", s.Teacher.Select(t => t.Name)),  // Преподаватели через запятую
                        Кабинет = s.Classroom.Number         // Аудитория
                    })
                    .ToList();


                // Привязываем данные к DataGridView
                ShelduleGrid.DataSource = filteredSchedules;
            }
            catch (Exception ex)
            {
             
            }
        }

        private async void NewShedulebtn_Click(object sender, EventArgs e)
        {
            // Получение выбранных значений из ComboBox
            var selectedWeekId = (int)WeekBox.SelectedValue;
   
            var selectedTimeId = (int)TimeBoxNew.SelectedValue;
            var selectedSubjectId = (int)SubjectBoxNew.SelectedValue;
            var selectedTypeSubject = (SubjectType)TypeSubjectNewBox.SelectedItem; // Используем тип перечисления
       
            var selectedRoomId = (int)RoomBoxNew.SelectedValue;
            var selectedDay = (DayOfWeekEnum)DayBox.SelectedValue; // Получаем значение из DayBox

            var selectedGroups = GroupBox.SelectedItems.Cast<StudentGroup>().ToList();
            var selectedTeachers = TeachersBoxNew.SelectedItems.Cast<Teacher>().ToList();

            var newSchedule = new Schedule
            {
                Group = selectedGroups,
                ClassTimeId = selectedTimeId,
                SubjectId = selectedSubjectId,
                SubjectType = selectedTypeSubject,
                Teacher = selectedTeachers,
                ClassroomId = selectedRoomId,
                DayOfWeek = selectedDay,
                WeekId = selectedWeekId
            };
            var result = await _scheduleService.CreateScheduleAsync(newSchedule);
            if (result.IsFailure)
            {
                MessageBox.Show(result.Error);
            }
            else
            {
                await _scheduleService.Create(newSchedule);
                await LoadComboBoxesAsync();
            }
        }

        private void ShelduleGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ShelduleGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectScheduleId = int.Parse(ShelduleGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectScheduleId = 0;
                }




            }
        }

        private async void DeleteShuduleBtn_Click(object sender, EventArgs e)
        {
            if (SelectScheduleId != 0)
            {
                var schedule = new Schedule
                {
                    Id = SelectScheduleId,

                };
                await _scheduleService.Delete(schedule);

                await LoadComboBoxesAsync();
            }
        }

        
    }
}
