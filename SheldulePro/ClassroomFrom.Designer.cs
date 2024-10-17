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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassroomFrom));
            RoomGrid = new DataGridView();
            SearchRoomText = new TextBox();
            NewNumberText = new TextBox();
            NewRoomBtn = new Button();
            DeleteRoomBtn = new Button();
            NewTypeText = new TextBox();
            UpdateTypeText = new TextBox();
            UpdateRoomBtn = new Button();
            UpdateNumberText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            SearchRoomText.PlaceholderText = "Поиск";
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
            NewRoomBtn.Size = new Size(274, 36);
            NewRoomBtn.TabIndex = 3;
            NewRoomBtn.Text = "Добавить";
            NewRoomBtn.UseVisualStyleBackColor = true;
            NewRoomBtn.Click += NewRoomBtn_Click;
            // 
            // DeleteRoomBtn
            // 
            DeleteRoomBtn.Location = new Point(294, 573);
            DeleteRoomBtn.Name = "DeleteRoomBtn";
            DeleteRoomBtn.Size = new Size(274, 49);
            DeleteRoomBtn.TabIndex = 6;
            DeleteRoomBtn.Text = "Удалить";
            DeleteRoomBtn.UseVisualStyleBackColor = true;
            DeleteRoomBtn.Click += DeleteRoomBtn_Click;
            // 
            // NewTypeText
            // 
            NewTypeText.Location = new Point(294, 90);
            NewTypeText.Name = "NewTypeText";
            NewTypeText.Size = new Size(274, 23);
            NewTypeText.TabIndex = 7;
            // 
            // UpdateTypeText
            // 
            UpdateTypeText.Location = new Point(294, 309);
            UpdateTypeText.Name = "UpdateTypeText";
            UpdateTypeText.Size = new Size(274, 23);
            UpdateTypeText.TabIndex = 10;
            // 
            // UpdateRoomBtn
            // 
            UpdateRoomBtn.Location = new Point(294, 348);
            UpdateRoomBtn.Name = "UpdateRoomBtn";
            UpdateRoomBtn.Size = new Size(274, 42);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 10);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 17;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 62);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 18;
            label2.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 281);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 20;
            label3.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 226);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 19;
            label4.Text = "Номер";
            // 
            // ClassroomFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 634);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdateTypeText);
            Controls.Add(UpdateRoomBtn);
            Controls.Add(UpdateNumberText);
            Controls.Add(NewTypeText);
            Controls.Add(DeleteRoomBtn);
            Controls.Add(NewRoomBtn);
            Controls.Add(NewNumberText);
            Controls.Add(SearchRoomText);
            Controls.Add(RoomGrid);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}