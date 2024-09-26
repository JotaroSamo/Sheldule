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
    }
}
