﻿namespace SheldulePro
{
    partial class SubjectForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            SubjectsGrid = new DataGridView();
            NewSubjectText = new TextBox();
            SearchText = new TextBox();
            UpdateSubjectText = new TextBox();
            NewSubjectBtn = new Button();
            UpdateSubjectBtn = new Button();
            DeleteSubjectbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SubjectsGrid).BeginInit();
            SuspendLayout();
            // 
            // SubjectsGrid
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            SubjectsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SubjectsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubjectsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            SubjectsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectsGrid.Location = new Point(12, 55);
            SubjectsGrid.Name = "SubjectsGrid";
            SubjectsGrid.Size = new Size(631, 653);
            SubjectsGrid.TabIndex = 0;
            SubjectsGrid.SelectionChanged += SubjectsGrid_SelectionChanged;
            // 
            // NewSubjectText
            // 
            NewSubjectText.Location = new Point(649, 55);
            NewSubjectText.Name = "NewSubjectText";
            NewSubjectText.Size = new Size(550, 23);
            NewSubjectText.TabIndex = 1;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(12, 26);
            SearchText.Name = "SearchText";
            SearchText.PlaceholderText = "Поиск";
            SearchText.Size = new Size(631, 23);
            SearchText.TabIndex = 2;
            SearchText.TextChanged += SearxhText_TextChanged;
            // 
            // UpdateSubjectText
            // 
            UpdateSubjectText.Location = new Point(649, 327);
            UpdateSubjectText.Name = "UpdateSubjectText";
            UpdateSubjectText.Size = new Size(550, 23);
            UpdateSubjectText.TabIndex = 3;
            // 
            // NewSubjectBtn
            // 
            NewSubjectBtn.Location = new Point(649, 96);
            NewSubjectBtn.Name = "NewSubjectBtn";
            NewSubjectBtn.Size = new Size(550, 43);
            NewSubjectBtn.TabIndex = 4;
            NewSubjectBtn.Text = "Добавить";
            NewSubjectBtn.UseVisualStyleBackColor = true;
            NewSubjectBtn.Click += NewSubjectBtn_Click;
            // 
            // UpdateSubjectBtn
            // 
            UpdateSubjectBtn.Location = new Point(649, 356);
            UpdateSubjectBtn.Name = "UpdateSubjectBtn";
            UpdateSubjectBtn.Size = new Size(550, 41);
            UpdateSubjectBtn.TabIndex = 5;
            UpdateSubjectBtn.Text = "Изменить";
            UpdateSubjectBtn.UseVisualStyleBackColor = true;
            UpdateSubjectBtn.Click += UpdateSubjectBtn_Click;
            // 
            // DeleteSubjectbtn
            // 
            DeleteSubjectbtn.Location = new Point(649, 415);
            DeleteSubjectbtn.Name = "DeleteSubjectbtn";
            DeleteSubjectbtn.Size = new Size(550, 42);
            DeleteSubjectbtn.TabIndex = 6;
            DeleteSubjectbtn.Text = "Удалить";
            DeleteSubjectbtn.UseVisualStyleBackColor = true;
            DeleteSubjectbtn.Click += DeleteSubjectbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(649, 296);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 20;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(649, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 19;
            label1.Text = "Название";
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 720);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteSubjectbtn);
            Controls.Add(UpdateSubjectBtn);
            Controls.Add(NewSubjectBtn);
            Controls.Add(UpdateSubjectText);
            Controls.Add(SearchText);
            Controls.Add(NewSubjectText);
            Controls.Add(SubjectsGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SubjectForm";
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)SubjectsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SubjectsGrid;
        private TextBox NewSubjectText;
        private TextBox SearchText;
        private TextBox UpdateSubjectText;
        private Button NewSubjectBtn;
        private Button UpdateSubjectBtn;
        private Button DeleteSubjectbtn;
        private Label label2;
        private Label label1;
    }
}