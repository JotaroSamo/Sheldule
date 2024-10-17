using Sheldule.Application;
using Sheldule.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SheldulePro
{
    public partial class SubjectForm : Form
    {
        private readonly SubjectService _subjectService = new SubjectService();
        private static int SelectID = 0;
        private readonly Main _main;

        public SubjectForm(Main main)
        {
            InitializeComponent();
            Style.ApplyGlobalStyles(this.Controls);
            Style.ApplyFormBackground(this);
            LoadSubjects();
            _main = main;
        }


        private async void LoadSubjects()
        {
            var subjects = await _subjectService.GetList();
            SubjectsGrid.DataSource = subjects;
        }
        private async void SearxhText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchText.Text))
            {
                SubjectsGrid.DataSource = await _subjectService.SearchByName(SearchText.Text);
            }
            else
            {
                LoadSubjects();
            }
        }

        private async void NewSubjectBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewSubjectText.Text))
            {
                var subject = new Subject
                {
                    Name = NewSubjectText.Text,
                };
                SubjectsGrid.DataSource = await _subjectService.Create(subject);
                LoadSubjects();
                await _main.LoadComboBoxesAsync();
            }
            else
            {
                MessageBox.Show("Значение null");
            }
        }

        private void SubjectsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SubjectsGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectID = int.Parse(SubjectsGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectID = 0;
                }

                UpdateSubjectText.Text = SubjectsGrid.CurrentRow.Cells["Name"].Value?.ToString();
            }
        }

        private async void UpdateSubjectBtn_Click(object sender, EventArgs e)
        {
            if (SelectID != 0 && !string.IsNullOrEmpty(UpdateSubjectText.Text))
            {
                var subject = new Subject
                {
                    Id = SelectID,
                    Name = NewSubjectText.Text,
                };
                await _subjectService.Update(subject);
                LoadSubjects();
                await _main.LoadComboBoxesAsync();
            }
        }

        private async void DeleteSubjectbtn_Click(object sender, EventArgs e)
        {
            if (SelectID != 0 && !string.IsNullOrEmpty(UpdateSubjectText.Text))
            {
                var subject = new Subject
                {
                    Id = SelectID,
                    Name = NewSubjectText.Text,
                };
                await _subjectService.Delete(subject);
                LoadSubjects();
                await _main.LoadComboBoxesAsync();
            }
        }
    }
}
