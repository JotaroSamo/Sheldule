using Sheldule.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheldulePro
{
    public partial class SubjectForm : Form
    {
        private readonly SubjectService _subjectService;

        public SubjectForm(SubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SearxhText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
