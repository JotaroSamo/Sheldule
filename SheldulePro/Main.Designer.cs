
namespace SheldulePro
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            TimeAndWeekBtn = new ToolStripButton();
            SubjectToolStrip = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TimeAndWeekBtn, SubjectToolStrip, toolStripButton3, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1209, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TimeAndWeekBtn
            // 
            TimeAndWeekBtn.Image = (Image)resources.GetObject("TimeAndWeekBtn.Image");
            TimeAndWeekBtn.ImageTransparentColor = Color.Magenta;
            TimeAndWeekBtn.Name = "TimeAndWeekBtn";
            TimeAndWeekBtn.Size = new Size(118, 22);
            TimeAndWeekBtn.Text = "Занятия и время";
            TimeAndWeekBtn.Click += TimeAndWeekBtn_Click;
            // 
            // SubjectToolStrip
            // 
            SubjectToolStrip.Image = (Image)resources.GetObject("SubjectToolStrip.Image");
            SubjectToolStrip.ImageTransparentColor = Color.Magenta;
            SubjectToolStrip.Name = "SubjectToolStrip";
            SubjectToolStrip.Size = new Size(84, 22);
            SubjectToolStrip.Text = "Предметы";
            SubjectToolStrip.Click += SubjectToolStrip_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(72, 22);
            toolStripButton3.Text = "Учителя";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(69, 22);
            toolStripButton1.Text = "Группы";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(81, 22);
            toolStripButton2.Text = "Кабинеты";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 716);
            Controls.Add(toolStrip1);
            Name = "Main";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton TimeAndWeekBtn;
        private ToolStripButton SubjectToolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}
