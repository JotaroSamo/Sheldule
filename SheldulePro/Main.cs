using Sheldule.Application;
using SheldulePro.Application;

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
        public Main()
        {
            InitializeComponent();
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            DayBox.DataSource = daysOfWeek;
            Load();
           
        }
        public async void Load()
        {
            WeekBox.DataSource = await _weekService.GetList();
            WeekBox.DisplayMember = "Number"; // Отображаем номер недели
            WeekBox.ValueMember = "Id"; // Значение - идентификатор недели
            WeekBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            WeekBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        #region toolbarbtn
        private void SubjectToolStrip_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
            if (subjectForm.DialogResult == DialogResult.OK)
            {
                subjectForm.Close();
            }
        }

        private void TimeAndWeekBtn_Click(object sender, EventArgs e)
        {
            TimeAndWeekForm timeAndWeekForm = new TimeAndWeekForm();
            timeAndWeekForm.ShowDialog();
            if (timeAndWeekForm.DialogResult == DialogResult.OK)
            {
                timeAndWeekForm.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TeachersForms teachersForms = new TeachersForms();
            teachersForms.ShowDialog();
            if (teachersForms.DialogResult == DialogResult.OK)
            {
                teachersForms.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
            if (groupForm.DialogResult == DialogResult.OK)
            {
                groupForm.Close();
            }
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            ClassroomFrom classroomFrom = new ClassroomFrom();
            classroomFrom.ShowDialog();
            if (classroomFrom.DialogResult == DialogResult.OK)
            {
                classroomFrom.Close();
            }
        }
        #endregion
    }
}
