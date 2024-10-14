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
            NewStartTimePicker.Location = new Point(304, 87);
            NewStartTimePicker.Name = "NewStartTimePicker";
            NewStartTimePicker.Size = new Size(226, 23);
            NewStartTimePicker.TabIndex = 3;
            NewStartTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewEndTimePicker
            // 
            NewEndTimePicker.Format = DateTimePickerFormat.Time;
            NewEndTimePicker.Location = new Point(304, 138);
            NewEndTimePicker.Name = "NewEndTimePicker";
            NewEndTimePicker.Size = new Size(226, 23);
            NewEndTimePicker.TabIndex = 4;
            NewEndTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateEndTimePicker
            // 
            UpdateEndTimePicker.Format = DateTimePickerFormat.Time;
            UpdateEndTimePicker.Location = new Point(304, 417);
            UpdateEndTimePicker.Name = "UpdateEndTimePicker";
            UpdateEndTimePicker.Size = new Size(226, 23);
            UpdateEndTimePicker.TabIndex = 7;
            UpdateEndTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateStartTimePicker
            // 
            UpdateStartTimePicker.Format = DateTimePickerFormat.Time;
            UpdateStartTimePicker.Location = new Point(304, 366);
            UpdateStartTimePicker.Name = "UpdateStartTimePicker";
            UpdateStartTimePicker.Size = new Size(226, 23);
            UpdateStartTimePicker.TabIndex = 6;
            UpdateStartTimePicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // SearchTimeText
            // 
            SearchTimeText.Location = new Point(12, 7);
            SearchTimeText.Name = "SearchTimeText";
            SearchTimeText.Size = new Size(286, 23);
            SearchTimeText.TabIndex = 8;
            SearchTimeText.TextChanged += SearchTimeText_TextChanged;
            // 
            // SearchWeekText
            // 
            SearchWeekText.Location = new Point(536, 6);
            SearchWeekText.Name = "SearchWeekText";
            SearchWeekText.Size = new Size(329, 23);
            SearchWeekText.TabIndex = 9;
            SearchWeekText.TextChanged += SearchWeekText_TextChanged;
            // 
            // NewTimeBtn
            // 
            NewTimeBtn.Location = new Point(304, 187);
            NewTimeBtn.Name = "NewTimeBtn";
            NewTimeBtn.Size = new Size(226, 23);
            NewTimeBtn.TabIndex = 10;
            NewTimeBtn.Text = "Добавить";
            NewTimeBtn.UseVisualStyleBackColor = true;
            NewTimeBtn.Click += NewTimeBtn_Click;
            // 
            // UpdateTimeBtn
            // 
            UpdateTimeBtn.Location = new Point(304, 461);
            UpdateTimeBtn.Name = "UpdateTimeBtn";
            UpdateTimeBtn.Size = new Size(226, 23);
            UpdateTimeBtn.TabIndex = 11;
            UpdateTimeBtn.Text = "Обновить";
            UpdateTimeBtn.UseVisualStyleBackColor = true;
            UpdateTimeBtn.Click += UpdateTimeBtn_Click;
            // 
            // UpdateWeekBtn
            // 
            UpdateWeekBtn.Location = new Point(871, 461);
            UpdateWeekBtn.Name = "UpdateWeekBtn";
            UpdateWeekBtn.Size = new Size(226, 23);
            UpdateWeekBtn.TabIndex = 19;
            UpdateWeekBtn.Text = "Обновить";
            UpdateWeekBtn.UseVisualStyleBackColor = true;
            UpdateWeekBtn.Click += UpdateWeekBtn_Click;
            // 
            // NewWeekBtn
            // 
            NewWeekBtn.Location = new Point(871, 187);
            NewWeekBtn.Name = "NewWeekBtn";
            NewWeekBtn.Size = new Size(226, 23);
            NewWeekBtn.TabIndex = 18;
            NewWeekBtn.Text = "Добавить";
            NewWeekBtn.UseVisualStyleBackColor = true;
            NewWeekBtn.Click += NewWeekBtn_Click;
            // 
            // UpdateWeekEndPicker
            // 
            UpdateWeekEndPicker.Format = DateTimePickerFormat.Short;
            UpdateWeekEndPicker.Location = new Point(871, 417);
            UpdateWeekEndPicker.Name = "UpdateWeekEndPicker";
            UpdateWeekEndPicker.Size = new Size(226, 23);
            UpdateWeekEndPicker.TabIndex = 17;
            UpdateWeekEndPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // UpdateWeekStartPicker
            // 
            UpdateWeekStartPicker.Format = DateTimePickerFormat.Short;
            UpdateWeekStartPicker.Location = new Point(871, 366);
            UpdateWeekStartPicker.Name = "UpdateWeekStartPicker";
            UpdateWeekStartPicker.Size = new Size(226, 23);
            UpdateWeekStartPicker.TabIndex = 16;
            UpdateWeekStartPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewWeekEndPicker
            // 
            NewWeekEndPicker.Format = DateTimePickerFormat.Short;
            NewWeekEndPicker.Location = new Point(871, 138);
            NewWeekEndPicker.Name = "NewWeekEndPicker";
            NewWeekEndPicker.Size = new Size(226, 23);
            NewWeekEndPicker.TabIndex = 14;
            NewWeekEndPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // NewWeekStartPicker
            // 
            NewWeekStartPicker.Format = DateTimePickerFormat.Short;
            NewWeekStartPicker.Location = new Point(871, 87);
            NewWeekStartPicker.Name = "NewWeekStartPicker";
            NewWeekStartPicker.Size = new Size(226, 23);
            NewWeekStartPicker.TabIndex = 13;
            NewWeekStartPicker.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // DeleteTimeBtn
            // 
            DeleteTimeBtn.Location = new Point(304, 589);
            DeleteTimeBtn.Name = "DeleteTimeBtn";
            DeleteTimeBtn.Size = new Size(226, 23);
            DeleteTimeBtn.TabIndex = 20;
            DeleteTimeBtn.Text = "Удалить";
            DeleteTimeBtn.UseVisualStyleBackColor = true;
            DeleteTimeBtn.Click += DeleteTimeBtn_Click;
            // 
            // DeleteWeekBtn
            // 
            DeleteWeekBtn.Location = new Point(871, 589);
            DeleteWeekBtn.Name = "DeleteWeekBtn";
            DeleteWeekBtn.Size = new Size(226, 23);
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
            // TimeAndWeekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 624);
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
    }
}