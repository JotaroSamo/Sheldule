namespace SheldulePro
{
    partial class TeachersForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForms));
            TeacherGrid = new DataGridView();
            NewNameTeaxherText = new TextBox();
            SearchTeachersText = new TextBox();
            NewTeacherBtn = new Button();
            UpdateNameTeacherText = new TextBox();
            UpdateTeacherBtn = new Button();
            DeleteTeacherBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TeacherGrid).BeginInit();
            SuspendLayout();
            // 
            // TeacherGrid
            // 
            TeacherGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherGrid.Location = new Point(12, 35);
            TeacherGrid.Name = "TeacherGrid";
            TeacherGrid.Size = new Size(403, 471);
            TeacherGrid.TabIndex = 0;
            TeacherGrid.SelectionChanged += TeacherGrid_SelectionChanged;
            // 
            // NewNameTeaxherText
            // 
            NewNameTeaxherText.Location = new Point(488, 35);
            NewNameTeaxherText.Name = "NewNameTeaxherText";
            NewNameTeaxherText.Size = new Size(235, 23);
            NewNameTeaxherText.TabIndex = 1;
            // 
            // SearchTeachersText
            // 
            SearchTeachersText.Location = new Point(12, 6);
            SearchTeachersText.Name = "SearchTeachersText";
            SearchTeachersText.Size = new Size(403, 23);
            SearchTeachersText.TabIndex = 2;
            SearchTeachersText.TextChanged += SearchTeachersText_TextChanged;
            // 
            // NewTeacherBtn
            // 
            NewTeacherBtn.Location = new Point(488, 85);
            NewTeacherBtn.Name = "NewTeacherBtn";
            NewTeacherBtn.Size = new Size(235, 37);
            NewTeacherBtn.TabIndex = 3;
            NewTeacherBtn.Text = "Добавить";
            NewTeacherBtn.UseVisualStyleBackColor = true;
            NewTeacherBtn.Click += NewTeacherBtn_Click;
            // 
            // UpdateNameTeacherText
            // 
            UpdateNameTeacherText.Location = new Point(488, 207);
            UpdateNameTeacherText.Name = "UpdateNameTeacherText";
            UpdateNameTeacherText.Size = new Size(235, 23);
            UpdateNameTeacherText.TabIndex = 5;
            // 
            // UpdateTeacherBtn
            // 
            UpdateTeacherBtn.Location = new Point(488, 252);
            UpdateTeacherBtn.Name = "UpdateTeacherBtn";
            UpdateTeacherBtn.Size = new Size(235, 39);
            UpdateTeacherBtn.TabIndex = 6;
            UpdateTeacherBtn.Text = "Обновить";
            UpdateTeacherBtn.UseVisualStyleBackColor = true;
            UpdateTeacherBtn.Click += UpdateTeacherBtn_Click;
            // 
            // DeleteTeacherBtn
            // 
            DeleteTeacherBtn.Location = new Point(488, 463);
            DeleteTeacherBtn.Name = "DeleteTeacherBtn";
            DeleteTeacherBtn.Size = new Size(235, 43);
            DeleteTeacherBtn.TabIndex = 7;
            DeleteTeacherBtn.Text = "Удалить";
            DeleteTeacherBtn.UseVisualStyleBackColor = true;
            DeleteTeacherBtn.Click += DeleteTeacherBtn_Click;
            // 
            // TeachersForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 518);
            Controls.Add(DeleteTeacherBtn);
            Controls.Add(UpdateTeacherBtn);
            Controls.Add(UpdateNameTeacherText);
            Controls.Add(NewTeacherBtn);
            Controls.Add(SearchTeachersText);
            Controls.Add(NewNameTeaxherText);
            Controls.Add(TeacherGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeachersForms";
            Text = "TeachersForms";
            ((System.ComponentModel.ISupportInitialize)TeacherGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TeacherGrid;
        private TextBox NewNameTeaxherText;
        private TextBox SearchTeachersText;
        private Button NewTeacherBtn;
        private TextBox UpdateNameTeacherText;
        private Button UpdateTeacherBtn;
        private Button DeleteTeacherBtn;
    }
}