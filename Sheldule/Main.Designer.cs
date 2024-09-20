namespace Sheldule
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SettingBtn = new System.Windows.Forms.ToolStripButton();
            this.DateTimeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingBtn,
            this.DateTimeBtn,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1386, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SettingBtn
            // 
            this.SettingBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingBtn.Image")));
            this.SettingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(87, 22);
            this.SettingBtn.Text = "Настройки";
            // 
            // DateTimeBtn
            // 
            this.DateTimeBtn.Image = ((System.Drawing.Image)(resources.GetObject("DateTimeBtn.Image")));
            this.DateTimeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DateTimeBtn.Name = "DateTimeBtn";
            this.DateTimeBtn.Size = new System.Drawing.Size(99, 22);
            this.DateTimeBtn.Text = "Дата и время";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group});
            this.dataGridView1.Location = new System.Drawing.Point(10, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1361, 644);
            this.dataGridView1.TabIndex = 7;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // WeekComboBox
            // 
            this.WeekComboBox.FormattingEnabled = true;
            this.WeekComboBox.Location = new System.Drawing.Point(12, 50);
            this.WeekComboBox.MinimumSize = new System.Drawing.Size(300, 0);
            this.WeekComboBox.Name = "WeekComboBox";
            this.WeekComboBox.Size = new System.Drawing.Size(300, 21);
            this.WeekComboBox.TabIndex = 8;
            // 
            // DayComboBox
            // 
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Location = new System.Drawing.Point(320, 50);
            this.DayComboBox.MinimumSize = new System.Drawing.Size(300, 0);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(300, 21);
            this.DayComboBox.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 736);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.WeekComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SettingBtn;
        private System.Windows.Forms.ToolStripButton DateTimeBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.ComboBox WeekComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
    }
}

