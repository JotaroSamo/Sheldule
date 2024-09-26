namespace Sheldule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameSubjectText = new System.Windows.Forms.TextBox();
            this.SearchSubject = new System.Windows.Forms.TextBox();
            this.UpadteNameSubjectText = new System.Windows.Forms.TextBox();
            this.NewSubjectBtn = new System.Windows.Forms.Button();
            this.UpdateSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameSubjectText
            // 
            this.NameSubjectText.Location = new System.Drawing.Point(472, 48);
            this.NameSubjectText.Name = "NameSubjectText";
            this.NameSubjectText.Size = new System.Drawing.Size(419, 20);
            this.NameSubjectText.TabIndex = 1;
            // 
            // SearchSubject
            // 
            this.SearchSubject.Location = new System.Drawing.Point(13, 24);
            this.SearchSubject.Name = "SearchSubject";
            this.SearchSubject.Size = new System.Drawing.Size(453, 20);
            this.SearchSubject.TabIndex = 2;
            this.SearchSubject.TextChanged += new System.EventHandler(this.SearchSubject_TextChanged);
            // 
            // UpadteNameSubjectText
            // 
            this.UpadteNameSubjectText.Location = new System.Drawing.Point(472, 324);
            this.UpadteNameSubjectText.Name = "UpadteNameSubjectText";
            this.UpadteNameSubjectText.Size = new System.Drawing.Size(419, 20);
            this.UpadteNameSubjectText.TabIndex = 3;
            // 
            // NewSubjectBtn
            // 
            this.NewSubjectBtn.Location = new System.Drawing.Point(472, 84);
            this.NewSubjectBtn.Name = "NewSubjectBtn";
            this.NewSubjectBtn.Size = new System.Drawing.Size(418, 23);
            this.NewSubjectBtn.TabIndex = 4;
            this.NewSubjectBtn.Text = "Добавить";
            this.NewSubjectBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateSubject
            // 
            this.UpdateSubject.Location = new System.Drawing.Point(473, 360);
            this.UpdateSubject.Name = "UpdateSubject";
            this.UpdateSubject.Size = new System.Drawing.Size(418, 23);
            this.UpdateSubject.TabIndex = 5;
            this.UpdateSubject.Text = "Изменить";
            this.UpdateSubject.UseVisualStyleBackColor = true;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 596);
            this.Controls.Add(this.UpdateSubject);
            this.Controls.Add(this.NewSubjectBtn);
            this.Controls.Add(this.UpadteNameSubjectText);
            this.Controls.Add(this.SearchSubject);
            this.Controls.Add(this.NameSubjectText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameSubjectText;
        private System.Windows.Forms.TextBox SearchSubject;
        private System.Windows.Forms.TextBox UpadteNameSubjectText;
        private System.Windows.Forms.Button NewSubjectBtn;
        private System.Windows.Forms.Button UpdateSubject;
    }
}