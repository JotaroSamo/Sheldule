namespace SheldulePro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
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
    }
}
