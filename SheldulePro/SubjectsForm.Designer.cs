namespace SheldulePro
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SubjectGrid = new DataGridView();
            NewSubjectText = new TextBox();
            SearxhText = new TextBox();
            UpdateSubjectText = new TextBox();
            NewSubjectBtn = new Button();
            UpdateSubjectBtn = new Button();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SubjectGrid).BeginInit();
            SuspendLayout();
            // 
            // SubjectGrid
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            SubjectGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            SubjectGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubjectGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            SubjectGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Name });
            SubjectGrid.Location = new Point(12, 55);
            SubjectGrid.Name = "SubjectGrid";
            SubjectGrid.Size = new Size(631, 653);
            SubjectGrid.TabIndex = 0;
            // 
            // NewSubjectText
            // 
            NewSubjectText.Location = new Point(649, 55);
            NewSubjectText.Name = "NewSubjectText";
            NewSubjectText.Size = new Size(550, 23);
            NewSubjectText.TabIndex = 1;
            // 
            // SearxhText
            // 
            SearxhText.Location = new Point(12, 26);
            SearxhText.Name = "SearxhText";
            SearxhText.Size = new Size(631, 23);
            SearxhText.TabIndex = 2;
            SearxhText.TextChanged += SearxhText_TextChanged;
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
            NewSubjectBtn.Size = new Size(550, 23);
            NewSubjectBtn.TabIndex = 4;
            NewSubjectBtn.Text = "Добавить";
            NewSubjectBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateSubjectBtn
            // 
            UpdateSubjectBtn.Location = new Point(649, 374);
            UpdateSubjectBtn.Name = "UpdateSubjectBtn";
            UpdateSubjectBtn.Size = new Size(550, 23);
            UpdateSubjectBtn.TabIndex = 5;
            UpdateSubjectBtn.Text = "Изменить";
            UpdateSubjectBtn.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.FillWeight = 152.284271F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Width = 240;
            // 
            // Name
            // 
            Name.FillWeight = 47.71573F;
            Name.HeaderText = "Предмет";
            Name.Name = "Name";
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 720);
            Controls.Add(UpdateSubjectBtn);
            Controls.Add(NewSubjectBtn);
            Controls.Add(UpdateSubjectText);
            Controls.Add(SearxhText);
            Controls.Add(NewSubjectText);
            Controls.Add(SubjectGrid);
         
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)SubjectGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SubjectGrid;
        private TextBox NewSubjectText;
        private TextBox SearxhText;
        private TextBox UpdateSubjectText;
        private Button NewSubjectBtn;
        private Button UpdateSubjectBtn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
    }
}