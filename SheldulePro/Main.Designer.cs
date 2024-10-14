
namespace SheldulePro
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            TimeAndWeekBtn = new ToolStripButton();
            SubjectToolStrip = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            Group = new ToolStripButton();
            RoomBtn = new ToolStripButton();
            DayBox = new ComboBox();
            WeekBox = new ComboBox();
            GroupBox = new ComboBox();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TimeAndWeekBtn, SubjectToolStrip, toolStripButton3, Group, RoomBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1209, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TimeAndWeekBtn
            // 
            TimeAndWeekBtn.Image = (Image)resources.GetObject("TimeAndWeekBtn.Image");
            TimeAndWeekBtn.ImageTransparentColor = Color.Magenta;
            TimeAndWeekBtn.Name = "TimeAndWeekBtn";
            TimeAndWeekBtn.Size = new Size(118, 22);
            TimeAndWeekBtn.Text = "Занятия и время";
            TimeAndWeekBtn.Click += TimeAndWeekBtn_Click;
            // 
            // SubjectToolStrip
            // 
            SubjectToolStrip.Image = (Image)resources.GetObject("SubjectToolStrip.Image");
            SubjectToolStrip.ImageTransparentColor = Color.Magenta;
            SubjectToolStrip.Name = "SubjectToolStrip";
            SubjectToolStrip.Size = new Size(84, 22);
            SubjectToolStrip.Text = "Предметы";
            SubjectToolStrip.Click += SubjectToolStrip_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(72, 22);
            toolStripButton3.Text = "Учителя";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // Group
            // 
            Group.Image = (Image)resources.GetObject("Group.Image");
            Group.ImageTransparentColor = Color.Magenta;
            Group.Name = "Group";
            Group.Size = new Size(69, 22);
            Group.Text = "Группы";
            Group.Click += toolStripButton1_Click;
            // 
            // RoomBtn
            // 
            RoomBtn.Image = (Image)resources.GetObject("RoomBtn.Image");
            RoomBtn.ImageTransparentColor = Color.Magenta;
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(81, 22);
            RoomBtn.Text = "Кабинеты";
            RoomBtn.Click += RoomBtn_Click;
            // 
            // DayBox
            // 
            DayBox.FormattingEnabled = true;
            DayBox.Location = new Point(107, 66);
            DayBox.Name = "DayBox";
            DayBox.Size = new Size(162, 23);
            DayBox.TabIndex = 1;
            // 
            // WeekBox
            // 
            WeekBox.FormattingEnabled = true;
            WeekBox.Location = new Point(12, 66);
            WeekBox.Name = "WeekBox";
            WeekBox.Size = new Size(64, 23);
            WeekBox.Sorted = true;
            WeekBox.TabIndex = 2;
            // 
            // GroupBox
            // 
            GroupBox.FormattingEnabled = true;
            GroupBox.Location = new Point(290, 66);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(218, 23);
            GroupBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(496, 480);
            dataGridView1.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 716);
            Controls.Add(dataGridView1);
            Controls.Add(GroupBox);
            Controls.Add(WeekBox);
            Controls.Add(DayBox);
            Controls.Add(toolStrip1);
            Name = "Main";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton TimeAndWeekBtn;
        private ToolStripButton SubjectToolStrip;
        private ToolStripButton Group;
        private ToolStripButton RoomBtn;
        private ComboBox DayBox;
        private ComboBox WeekBox;
        private ComboBox GroupBox;
        private DataGridView dataGridView1;
    }
}
