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
            dataGridView2 = new DataGridView();
            NewStartTimePicker = new DateTimePicker();
            NewEndTimePicker = new DateTimePicker();
            UpdateEndTimePicker = new DateTimePicker();
            UpdateStartTimePicker = new DateTimePicker();
            SearchTimeText = new TextBox();
            textBox4 = new TextBox();
            NewTimeBtn = new Button();
            UpdateTimeBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            textBox5 = new TextBox();
            dateTimePicker7 = new DateTimePicker();
            dateTimePicker8 = new DateTimePicker();
            textBox6 = new TextBox();
            DeleteTimeBtn = new Button();
            button2 = new Button();
            NewTimeText = new MaskedTextBox();
            UpdateTimeText = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)TimeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(536, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(329, 577);
            dataGridView2.TabIndex = 1;
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
            // textBox4
            // 
            textBox4.Location = new Point(536, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 23);
            textBox4.TabIndex = 9;
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
            // button3
            // 
            button3.Location = new Point(871, 461);
            button3.Name = "button3";
            button3.Size = new Size(226, 23);
            button3.TabIndex = 19;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(871, 187);
            button4.Name = "button4";
            button4.Size = new Size(226, 23);
            button4.TabIndex = 18;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(871, 417);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(226, 23);
            dateTimePicker5.TabIndex = 17;
            dateTimePicker5.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Format = DateTimePickerFormat.Short;
            dateTimePicker6.Location = new Point(871, 366);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(226, 23);
            dateTimePicker6.TabIndex = 16;
            dateTimePicker6.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // textBox5
            // 
            textBox5.Location = new Point(871, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 23);
            textBox5.TabIndex = 15;
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Format = DateTimePickerFormat.Short;
            dateTimePicker7.Location = new Point(871, 138);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(226, 23);
            dateTimePicker7.TabIndex = 14;
            dateTimePicker7.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // dateTimePicker8
            // 
            dateTimePicker8.Format = DateTimePickerFormat.Short;
            dateTimePicker8.Location = new Point(871, 87);
            dateTimePicker8.Name = "dateTimePicker8";
            dateTimePicker8.Size = new Size(226, 23);
            dateTimePicker8.TabIndex = 13;
            dateTimePicker8.Value = new DateTime(2024, 9, 26, 15, 7, 0, 0);
            // 
            // textBox6
            // 
            textBox6.Location = new Point(871, 35);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(226, 23);
            textBox6.TabIndex = 12;
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
            // button2
            // 
            button2.Location = new Point(871, 589);
            button2.Name = "button2";
            button2.Size = new Size(226, 23);
            button2.TabIndex = 21;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
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
            // TimeAndWeekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 624);
            Controls.Add(UpdateTimeText);
            Controls.Add(NewTimeText);
            Controls.Add(button2);
            Controls.Add(DeleteTimeBtn);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dateTimePicker5);
            Controls.Add(dateTimePicker6);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker7);
            Controls.Add(dateTimePicker8);
            Controls.Add(textBox6);
            Controls.Add(UpdateTimeBtn);
            Controls.Add(NewTimeBtn);
            Controls.Add(textBox4);
            Controls.Add(SearchTimeText);
            Controls.Add(UpdateEndTimePicker);
            Controls.Add(UpdateStartTimePicker);
            Controls.Add(NewEndTimePicker);
            Controls.Add(NewStartTimePicker);
            Controls.Add(dataGridView2);
            Controls.Add(TimeGrid);
            Name = "TimeAndWeekForm";
            Text = "TimeAndWeekForm";
            ((System.ComponentModel.ISupportInitialize)TimeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TimeGrid;
        private DataGridView dataGridView2;
        private DateTimePicker NewStartTimePicker;
        private DateTimePicker NewEndTimePicker;
        private DateTimePicker UpdateEndTimePicker;
        private DateTimePicker UpdateStartTimePicker;
        private TextBox SearchTimeText;
        private TextBox textBox4;
        private Button NewTimeBtn;
        private Button UpdateTimeBtn;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker7;
        private DateTimePicker dateTimePicker8;
        private TextBox textBox6;
        private Button DeleteTimeBtn;
        private Button button2;
        private MaskedTextBox NewTimeText;
        private MaskedTextBox UpdateTimeText;
    }
}