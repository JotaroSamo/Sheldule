
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
            ShelduleGrid = new DataGridView();
            TimeBoxNew = new ComboBox();
            RoomBoxNew = new ComboBox();
            NewShedulebtn = new Button();
            SubjectBoxNew = new ComboBox();
            TypeSubjectNewBox = new ComboBox();
            TeachersBoxNew = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DeleteShuduleBtn = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShelduleGrid).BeginInit();
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
            DayBox.SelectedIndexChanged += WeekBox_SelectedIndexChanged;
            // 
            // WeekBox
            // 
            WeekBox.FormattingEnabled = true;
            WeekBox.Location = new Point(12, 66);
            WeekBox.Name = "WeekBox";
            WeekBox.Size = new Size(64, 23);
            WeekBox.Sorted = true;
            WeekBox.TabIndex = 2;
            WeekBox.SelectedIndexChanged += WeekBox_SelectedIndexChanged;
            // 
            // GroupBox
            // 
            GroupBox.FormattingEnabled = true;
            GroupBox.Location = new Point(290, 66);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(218, 23);
            GroupBox.TabIndex = 3;
            GroupBox.SelectedIndexChanged += WeekBox_SelectedIndexChanged;
            // 
            // ShelduleGrid
            // 
            ShelduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShelduleGrid.Location = new Point(12, 112);
            ShelduleGrid.Name = "ShelduleGrid";
            ShelduleGrid.Size = new Size(651, 480);
            ShelduleGrid.TabIndex = 4;
            ShelduleGrid.SelectionChanged += ShelduleGrid_SelectionChanged;
            // 
            // TimeBoxNew
            // 
            TimeBoxNew.FormattingEnabled = true;
            TimeBoxNew.Location = new Point(688, 112);
            TimeBoxNew.Name = "TimeBoxNew";
            TimeBoxNew.Size = new Size(444, 23);
            TimeBoxNew.TabIndex = 7;
            // 
            // RoomBoxNew
            // 
            RoomBoxNew.FormattingEnabled = true;
            RoomBoxNew.Location = new Point(688, 417);
            RoomBoxNew.Name = "RoomBoxNew";
            RoomBoxNew.Size = new Size(444, 23);
            RoomBoxNew.TabIndex = 11;
            // 
            // NewShedulebtn
            // 
            NewShedulebtn.Location = new Point(688, 469);
            NewShedulebtn.Name = "NewShedulebtn";
            NewShedulebtn.Size = new Size(444, 40);
            NewShedulebtn.TabIndex = 12;
            NewShedulebtn.Text = "Добавить";
            NewShedulebtn.UseVisualStyleBackColor = true;
            NewShedulebtn.Click += NewShedulebtn_Click;
            // 
            // SubjectBoxNew
            // 
            SubjectBoxNew.FormattingEnabled = true;
            SubjectBoxNew.Location = new Point(688, 185);
            SubjectBoxNew.Name = "SubjectBoxNew";
            SubjectBoxNew.Size = new Size(444, 23);
            SubjectBoxNew.TabIndex = 13;
            // 
            // TypeSubjectNewBox
            // 
            TypeSubjectNewBox.FormattingEnabled = true;
            TypeSubjectNewBox.Location = new Point(688, 270);
            TypeSubjectNewBox.Name = "TypeSubjectNewBox";
            TypeSubjectNewBox.Size = new Size(444, 23);
            TypeSubjectNewBox.TabIndex = 14;
            // 
            // TeachersBoxNew
            // 
            TeachersBoxNew.FormattingEnabled = true;
            TeachersBoxNew.Location = new Point(688, 347);
            TeachersBoxNew.Name = "TeachersBoxNew";
            TeachersBoxNew.Size = new Size(444, 23);
            TeachersBoxNew.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 16;
            label1.Text = "Неделя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 39);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 17;
            label2.Text = "День";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 39);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 18;
            label3.Text = "Группа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(688, 69);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 19;
            label4.Text = "Пара";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 151);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 20;
            label5.Text = "Предмет";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(688, 234);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 21;
            label6.Text = "Тип предмета";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(688, 314);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 22;
            label7.Text = "Учитель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(688, 386);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 23;
            label8.Text = "Кабинет";
            // 
            // DeleteShuduleBtn
            // 
            DeleteShuduleBtn.Location = new Point(12, 598);
            DeleteShuduleBtn.Name = "DeleteShuduleBtn";
            DeleteShuduleBtn.Size = new Size(651, 40);
            DeleteShuduleBtn.TabIndex = 24;
            DeleteShuduleBtn.Text = "Удалить";
            DeleteShuduleBtn.UseVisualStyleBackColor = true;
            DeleteShuduleBtn.Click += DeleteShuduleBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 716);
            Controls.Add(DeleteShuduleBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TeachersBoxNew);
            Controls.Add(TypeSubjectNewBox);
            Controls.Add(SubjectBoxNew);
            Controls.Add(NewShedulebtn);
            Controls.Add(RoomBoxNew);
            Controls.Add(TimeBoxNew);
            Controls.Add(ShelduleGrid);
            Controls.Add(GroupBox);
            Controls.Add(WeekBox);
            Controls.Add(DayBox);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Расписание";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShelduleGrid).EndInit();
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
        private DataGridView ShelduleGrid;
        private ComboBox WeekBoxNew;
        private ComboBox DayBoxNew;
        private ComboBox TimeBoxNew;
        private ComboBox GroupBoxNew;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox RoomBoxNew;
        private Button NewShedulebtn;
        private ComboBox SubjectBoxNew;
        private ComboBox TypeSubjectNewBox;
        private ComboBox TeachersBoxNew;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button DeleteShuduleBtn;
    }
}
