namespace SheldulePro
{
    partial class GroupForm
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
            GroupGrid = new DataGridView();
            NewGroupText = new TextBox();
            NewGroupBtn = new Button();
            UpdateGroupBtn = new Button();
            UpdateGroupText = new TextBox();
            DeleteGroupBtn = new Button();
            SearchGroupText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GroupGrid).BeginInit();
            SuspendLayout();
            // 
            // GroupGrid
            // 
            GroupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GroupGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GroupGrid.Location = new Point(12, 30);
            GroupGrid.Name = "GroupGrid";
            GroupGrid.Size = new Size(181, 408);
            GroupGrid.TabIndex = 0;
            GroupGrid.SelectionChanged += GroupGrid_SelectionChanged;
            // 
            // NewGroupText
            // 
            NewGroupText.Location = new Point(199, 30);
            NewGroupText.Name = "NewGroupText";
            NewGroupText.Size = new Size(211, 23);
            NewGroupText.TabIndex = 1;
            // 
            // NewGroupBtn
            // 
            NewGroupBtn.Location = new Point(199, 69);
            NewGroupBtn.Name = "NewGroupBtn";
            NewGroupBtn.Size = new Size(211, 23);
            NewGroupBtn.TabIndex = 2;
            NewGroupBtn.Text = "Добавить";
            NewGroupBtn.UseVisualStyleBackColor = true;
            NewGroupBtn.Click += NewGroupBtn_Click;
            // 
            // UpdateGroupBtn
            // 
            UpdateGroupBtn.Location = new Point(199, 223);
            UpdateGroupBtn.Name = "UpdateGroupBtn";
            UpdateGroupBtn.Size = new Size(211, 23);
            UpdateGroupBtn.TabIndex = 4;
            UpdateGroupBtn.Text = "Обновить";
            UpdateGroupBtn.UseVisualStyleBackColor = true;
            UpdateGroupBtn.Click += UpdateGroupBtn_Click;
            // 
            // UpdateGroupText
            // 
            UpdateGroupText.Location = new Point(199, 184);
            UpdateGroupText.Name = "UpdateGroupText";
            UpdateGroupText.Size = new Size(211, 23);
            UpdateGroupText.TabIndex = 3;
            // 
            // DeleteGroupBtn
            // 
            DeleteGroupBtn.Location = new Point(199, 415);
            DeleteGroupBtn.Name = "DeleteGroupBtn";
            DeleteGroupBtn.Size = new Size(211, 23);
            DeleteGroupBtn.TabIndex = 5;
            DeleteGroupBtn.Text = "Удалить";
            DeleteGroupBtn.UseVisualStyleBackColor = true;
            DeleteGroupBtn.Click += DeleteGroupBtn_Click;
            // 
            // SearchGroupText
            // 
            SearchGroupText.Location = new Point(12, 1);
            SearchGroupText.Name = "SearchGroupText";
            SearchGroupText.Size = new Size(181, 23);
            SearchGroupText.TabIndex = 6;
            SearchGroupText.SizeChanged += SearchGroupText_SizeChanged;
            // 
            // GroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 450);
            Controls.Add(SearchGroupText);
            Controls.Add(DeleteGroupBtn);
            Controls.Add(UpdateGroupBtn);
            Controls.Add(UpdateGroupText);
            Controls.Add(NewGroupBtn);
            Controls.Add(NewGroupText);
            Controls.Add(GroupGrid);
            Name = "GroupForm";
            Text = "GroupForm";
            ((System.ComponentModel.ISupportInitialize)GroupGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GroupGrid;
        private TextBox NewGroupText;
        private Button NewGroupBtn;
        private Button UpdateGroupBtn;
        private TextBox UpdateGroupText;
        private Button DeleteGroupBtn;
        private TextBox SearchGroupText;
    }
}