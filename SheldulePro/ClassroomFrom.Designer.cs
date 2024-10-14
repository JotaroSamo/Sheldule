namespace SheldulePro
{
    partial class ClassroomFrom
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
            RoomGrid = new DataGridView();
            SearchRoomText = new TextBox();
            NewNumberText = new TextBox();
            NewRoomBtn = new Button();
            DeleteRoomBtn = new Button();
            NewTypeText = new TextBox();
            UpdateTypeText = new TextBox();
            UpdateRoomBtn = new Button();
            UpdateNumberText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)RoomGrid).BeginInit();
            SuspendLayout();
            // 
            // RoomGrid
            // 
            RoomGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RoomGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomGrid.Location = new Point(12, 36);
            RoomGrid.Name = "RoomGrid";
            RoomGrid.Size = new Size(276, 586);
            RoomGrid.TabIndex = 0;
            RoomGrid.SelectionChanged += RoomGrid_SelectionChanged;
            // 
            // SearchRoomText
            // 
            SearchRoomText.Location = new Point(12, 7);
            SearchRoomText.Name = "SearchRoomText";
            SearchRoomText.Size = new Size(276, 23);
            SearchRoomText.TabIndex = 1;
            SearchRoomText.TextChanged += SearchRoomText_TextChanged;
            // 
            // NewNumberText
            // 
            NewNumberText.Location = new Point(294, 36);
            NewNumberText.Name = "NewNumberText";
            NewNumberText.Size = new Size(274, 23);
            NewNumberText.TabIndex = 2;
            // 
            // NewRoomBtn
            // 
            NewRoomBtn.Location = new Point(294, 130);
            NewRoomBtn.Name = "NewRoomBtn";
            NewRoomBtn.Size = new Size(274, 23);
            NewRoomBtn.TabIndex = 3;
            NewRoomBtn.Text = "Добавить";
            NewRoomBtn.UseVisualStyleBackColor = true;
            NewRoomBtn.Click += NewRoomBtn_Click;
            // 
            // DeleteRoomBtn
            // 
            DeleteRoomBtn.Location = new Point(294, 599);
            DeleteRoomBtn.Name = "DeleteRoomBtn";
            DeleteRoomBtn.Size = new Size(274, 23);
            DeleteRoomBtn.TabIndex = 6;
            DeleteRoomBtn.Text = "Удалить";
            DeleteRoomBtn.UseVisualStyleBackColor = true;
            DeleteRoomBtn.Click += DeleteRoomBtn_Click;
            // 
            // NewTypeText
            // 
            NewTypeText.Location = new Point(294, 81);
            NewTypeText.Name = "NewTypeText";
            NewTypeText.Size = new Size(274, 23);
            NewTypeText.TabIndex = 7;
            // 
            // UpdateTypeText
            // 
            UpdateTypeText.Location = new Point(294, 299);
            UpdateTypeText.Name = "UpdateTypeText";
            UpdateTypeText.Size = new Size(274, 23);
            UpdateTypeText.TabIndex = 10;
            // 
            // UpdateRoomBtn
            // 
            UpdateRoomBtn.Location = new Point(294, 348);
            UpdateRoomBtn.Name = "UpdateRoomBtn";
            UpdateRoomBtn.Size = new Size(274, 23);
            UpdateRoomBtn.TabIndex = 9;
            UpdateRoomBtn.Text = "Обновить";
            UpdateRoomBtn.UseVisualStyleBackColor = true;
            UpdateRoomBtn.Click += UpdateRoomBtn_Click;
            // 
            // UpdateNumberText
            // 
            UpdateNumberText.Location = new Point(294, 254);
            UpdateNumberText.Name = "UpdateNumberText";
            UpdateNumberText.Size = new Size(274, 23);
            UpdateNumberText.TabIndex = 8;
            // 
            // ClassroomFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 634);
            Controls.Add(UpdateTypeText);
            Controls.Add(UpdateRoomBtn);
            Controls.Add(UpdateNumberText);
            Controls.Add(NewTypeText);
            Controls.Add(DeleteRoomBtn);
            Controls.Add(NewRoomBtn);
            Controls.Add(NewNumberText);
            Controls.Add(SearchRoomText);
            Controls.Add(RoomGrid);
            Name = "ClassroomFrom";
            Text = "ClassroomFrom";
            ((System.ComponentModel.ISupportInitialize)RoomGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RoomGrid;
        private TextBox SearchRoomText;
        private TextBox NewNumberText;
        private Button NewRoomBtn;
        private Button DeleteRoomBtn;
        private TextBox NewTypeText;
        private TextBox UpdateTypeText;
        private Button UpdateRoomBtn;
        private TextBox UpdateNumberText;
    }
}