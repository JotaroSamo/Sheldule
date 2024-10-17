namespace SheldulePro
{
    partial class TimeAndWeekForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeAndWeekForm));
            TimeGrid = new DataGridView();
            WeekGrid = new DataGridView();
            NewStartTimePicker = new DateTimePicker();
            NewEndTimePicker = new DateTimePicker();
            UpdateEndTimePicker = new DateTimePicker();
            UpdateStartTimePicker = new DateTimePicker();
            SearchTimeText = new TextBox();
            SearchWeekText = new TextBox();
            NewTimeBtn = new Button();
            UpdateTimeBtn = new Button();
            UpdateWeekBtn = new Button();
            NewWeekBtn = new Button();
            UpdateWeekEndPicker = new DateTimePicker();
            UpdateWeekStartPicker = new DateTimePicker();
            NewWeekEndPicker = new DateTimePicker();
            NewWeekStartPicker = new DateTimePicker();
            DeleteTimeBtn = new Button();
            DeleteWeekBtn = new Button();
            NewTimeText = new MaskedTextBox();
            UpdateTimeText = new MaskedTextBox();
            NewNameWeekText = new MaskedTextBox();
            UpdateNameWeekText = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)TimeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeekGrid).BeginInit();
            SuspendLayout();
            // 
            // TimeGrid
            // 
            TimeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TimeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TimeGrid.Location = new Point(12, 35);
            TimeGrid.Name = "TimeGrid";
            TimeGrid.Size = new Size(286, 577);
            TimeGrid.TabIndex = 0;
            TimeGrid.SelectionChanged += TimeGrid_SelectionChanged;
            // 
            // WeekGrid
            // 
            WeekGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WeekGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WeekGrid.Location = new Point(536, 35);
            WeekGrid.Name = "WeekGrid";
            WeekGrid.Size = new Size(329, 577);
            WeekGrid.TabIndex = 1;
            WeekGrid.SelectionChanged += WeekGrid_SelectionChanged;
            // 
            // NewStartTimePicker
            // 
            NewStartTimePicker.Format = DateTimePickerFormat.Time;
            NewStartTimePicker.Location = new Point(304, 99);
            NewStartTimePicker.Name = "NewStartTimePicker";
            NewStartTimePicker.Size = new Size(226, 23);
            NewStartTimePicker.TabIndex = 3;
            NewStartTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewEndTimePicker
            // 
            NewEndTimePicker.Format = DateTimePickerFormat.Time;
            NewEndTimePicker.Location = new Point(304, 174);
            NewEndTimePicker.Name = "NewEndTimePicker";
            NewEndTimePicker.Size = new Size(226, 23);
            NewEndTimePicker.TabIndex = 4;
            NewEndTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateEndTimePicker
            // 
            UpdateEndTimePicker.Format = DateTimePickerFormat.Time;
            UpdateEndTimePicker.Location = new Point(304, 451);
            UpdateEndTimePicker.Name = "UpdateEndTimePicker";
            UpdateEndTimePicker.Size = new Size(226, 23);
            UpdateEndTimePicker.TabIndex = 7;
            UpdateEndTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateStartTimePicker
            // 
            UpdateStartTimePicker.Format = DateTimePickerFormat.Time;
            UpdateStartTimePicker.Location = new Point(304, 377);
            UpdateStartTimePicker.Name = "UpdateStartTimePicker";
            UpdateStartTimePicker.Size = new Size(226, 23);
            UpdateStartTimePicker.TabIndex = 6;
            UpdateStartTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // SearchTimeText
            // 
            SearchTimeText.Location = new Point(12, 7);
            SearchTimeText.Name = "SearchTimeText";
            SearchTimeText.PlaceholderText = "Поиск";
            SearchTimeText.Size = new Size(286, 23);
            SearchTimeText.TabIndex = 8;
            SearchTimeText.TextChanged += SearchTimeText_TextChanged;
            // 
            // SearchWeekText
            // 
            SearchWeekText.Location = new Point(536, 6);
            SearchWeekText.Name = "SearchWeekText";
            SearchWeekText.PlaceholderText = "Поиск";
            SearchWeekText.Size = new Size(329, 23);
            SearchWeekText.TabIndex = 9;
            SearchWeekText.TextChanged += SearchWeekText_TextChanged;
            // 
            // NewTimeBtn
            // 
            NewTimeBtn.Location = new Point(304, 203);
            NewTimeBtn.Name = "NewTimeBtn";
            NewTimeBtn.Size = new Size(226, 43);
            NewTimeBtn.TabIndex = 10;
            NewTimeBtn.Text = "Добавить";
            NewTimeBtn.UseVisualStyleBackColor = true;
            NewTimeBtn.Click += NewTimeBtn_Click;
            // 
            // UpdateTimeBtn
            // 
            UpdateTimeBtn.Location = new Point(304, 480);
            UpdateTimeBtn.Name = "UpdateTimeBtn";
            UpdateTimeBtn.Size = new Size(226, 40);
            UpdateTimeBtn.TabIndex = 11;
            UpdateTimeBtn.Text = "Обновить";
            UpdateTimeBtn.UseVisualStyleBackColor = true;
            UpdateTimeBtn.Click += UpdateTimeBtn_Click;
            // 
            // UpdateWeekBtn
            // 
            UpdateWeekBtn.Location = new Point(871, 480);
            UpdateWeekBtn.Name = "UpdateWeekBtn";
            UpdateWeekBtn.Size = new Size(226, 40);
            UpdateWeekBtn.TabIndex = 19;
            UpdateWeekBtn.Text = "Обновить";
            UpdateWeekBtn.UseVisualStyleBackColor = true;
            UpdateWeekBtn.Click += UpdateWeekBtn_Click;
            // 
            // NewWeekBtn
            // 
            NewWeekBtn.Location = new Point(871, 203);
            NewWeekBtn.Name = "NewWeekBtn";
            NewWeekBtn.Size = new Size(226, 43);
            NewWeekBtn.TabIndex = 18;
            NewWeekBtn.Text = "Добавить";
            NewWeekBtn.UseVisualStyleBackColor = true;
            NewWeekBtn.Click += NewWeekBtn_Click;
            // 
            // UpdateWeekEndPicker
            // 
            UpdateWeekEndPicker.Format = DateTimePickerFormat.Short;
            UpdateWeekEndPicker.Location = new Point(871, 451);
            UpdateWeekEndPicker.Name = "UpdateWeekEndPicker";
            UpdateWeekEndPicker.Size = new Size(226, 23);
            UpdateWeekEndPicker.TabIndex = 17;
            UpdateWeekEndPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateWeekStartPicker
            // 
            UpdateWeekStartPicker.Format = DateTimePickerFormat.Short;
            UpdateWeekStartPicker.Location = new Point(871, 377);
            UpdateWeekStartPicker.Name = "UpdateWeekStartPicker";
            UpdateWeekStartPicker.Size = new Size(226, 23);
            UpdateWeekStartPicker.TabIndex = 16;
            UpdateWeekStartPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewWeekEndPicker
            // 
            NewWeekEndPicker.Format = DateTimePickerFormat.Short;
            NewWeekEndPicker.Location = new Point(871, 174);
            NewWeekEndPicker.Name = "NewWeekEndPicker";
            NewWeekEndPicker.Size = new Size(226, 23);
            NewWeekEndPicker.TabIndex = 14;
            NewWeekEndPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewWeekStartPicker
            // 
            NewWeekStartPicker.Format = DateTimePickerFormat.Short;
            NewWeekStartPicker.Location = new Point(871, 99);
            NewWeekStartPicker.Name = "NewWeekStartPicker";
            NewWeekStartPicker.Size = new Size(226, 23);
            NewWeekStartPicker.TabIndex = 13;
            NewWeekStartPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // DeleteTimeBtn
            // 
            DeleteTimeBtn.Location = new Point(304, 572);
            DeleteTimeBtn.Name = "DeleteTimeBtn";
            DeleteTimeBtn.Size = new Size(226, 40);
            DeleteTimeBtn.TabIndex = 20;
            DeleteTimeBtn.Text = "Удалить";
            DeleteTimeBtn.UseVisualStyleBackColor = true;
            DeleteTimeBtn.Click += DeleteTimeBtn_Click;
            // 
            // DeleteWeekBtn
            // 
            DeleteWeekBtn.Location = new Point(871, 572);
            DeleteWeekBtn.Name = "DeleteWeekBtn";
            DeleteWeekBtn.Size = new Size(226, 40);
            DeleteWeekBtn.TabIndex = 21;
            DeleteWeekBtn.Text = "Удалить";
            DeleteWeekBtn.UseVisualStyleBackColor = true;
            DeleteWeekBtn.Click += DeleteWeekBtn_Click;
            // 
            // NewTimeText
            // 
            NewTimeText.Location = new Point(304, 35);
            NewTimeText.Mask = "00000";
            NewTimeText.Name = "NewTimeText";
            NewTimeText.Size = new Size(226, 23);
            NewTimeText.TabIndex = 22;
            NewTimeText.ValidatingType = typeof(int);
            // 
            // UpdateTimeText
            // 
            UpdateTimeText.Location = new Point(304, 314);
            UpdateTimeText.Mask = "00000";
            UpdateTimeText.Name = "UpdateTimeText";
            UpdateTimeText.Size = new Size(226, 23);
            UpdateTimeText.TabIndex = 23;
            UpdateTimeText.ValidatingType = typeof(int);
            // 
            // NewNameWeekText
            // 
            NewNameWeekText.Location = new Point(871, 35);
            NewNameWeekText.Mask = "00000";
            NewNameWeekText.Name = "NewNameWeekText";
            NewNameWeekText.Size = new Size(226, 23);
            NewNameWeekText.TabIndex = 24;
            NewNameWeekText.ValidatingType = typeof(int);
            // 
            // UpdateNameWeekText
            // 
            UpdateNameWeekText.Location = new Point(871, 314);
            UpdateNameWeekText.Mask = "00000";
            UpdateNameWeekText.Name = "UpdateNameWeekText";
            UpdateNameWeekText.Size = new Size(226, 23);
            UpdateNameWeekText.TabIndex = 25;
            UpdateNameWeekText.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 69);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 27;
            label2.Text = "Начало";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 26;
            label1.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 138);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 28;
            label3.Text = "Конец";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 417);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 31;
            label4.Text = "Конец";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 348);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 30;
            label5.Text = "Начало";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 284);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 29;
            label6.Text = "Номер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(871, 138);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 34;
            label7.Text = "Конец";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(871, 69);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 33;
            label8.Text = "Начало";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(871, 6);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 32;
            label9.Text = "Номер";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(871, 417);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 37;
            label10.Text = "Конец";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(871, 348);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 36;
            label11.Text = "Начало";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(871, 284);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 35;
            label12.Text = "Номер";
            // 
            // TimeAndWeekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 624);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateNameWeekText);
            Controls.Add(NewNameWeekText);
            Controls.Add(UpdateTimeText);
            Controls.Add(NewTimeText);
            Controls.Add(DeleteWeekBtn);
            Controls.Add(DeleteTimeBtn);
            Controls.Add(UpdateWeekBtn);
            Controls.Add(NewWeekBtn);
            Controls.Add(UpdateWeekEndPicker);
            Controls.Add(UpdateWeekStartPicker);
            Controls.Add(NewWeekEndPicker);
            Controls.Add(NewWeekStartPicker);
            Controls.Add(UpdateTimeBtn);
            Controls.Add(NewTimeBtn);
            Controls.Add(SearchWeekText);
            Controls.Add(SearchTimeText);
            Controls.Add(UpdateEndTimePicker);
            Controls.Add(UpdateStartTimePicker);
            Controls.Add(NewEndTimePicker);
            Controls.Add(NewStartTimePicker);
            Controls.Add(WeekGrid);
            Controls.Add(TimeGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TimeAndWeekForm";
            Text = "TimeAndWeekForm";
            ((System.ComponentModel.ISupportInitialize)TimeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeekGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TimeGrid;
        private DataGridView WeekGrid;
        private DateTimePicker NewStartTimePicker;
        private DateTimePicker NewEndTimePicker;
        private DateTimePicker UpdateEndTimePicker;
        private DateTimePicker UpdateStartTimePicker;
        private TextBox SearchTimeText;
        private TextBox SearchWeekText;
        private Button NewTimeBtn;
        private Button UpdateTimeBtn;
        private Button UpdateWeekBtn;
        private Button NewWeekBtn;
        private DateTimePicker UpdateWeekEndPicker;
        private DateTimePicker UpdateWeekStartPicker;
        private DateTimePicker NewWeekEndPicker;
        private DateTimePicker NewWeekStartPicker;
        private Button DeleteTimeBtn;
        private Button DeleteWeekBtn;
        private MaskedTextBox NewTimeText;
        private MaskedTextBox UpdateTimeText;
        private MaskedTextBox NewNameWeekText;
        private MaskedTextBox UpdateNameWeekText;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}