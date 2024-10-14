using Sheldule.DataAccess.Model;
using SheldulePro.Application;
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
    public partial class TeachersForms : Form
    {
        private readonly TeacherService _teacherService = new TeacherService();
        private int SelectTeacherID = 0;
        public TeachersForms()
        {
            InitializeComponent();
            LoadTeacher();
        }
        private async void LoadTeacher()
        {
            var teacher = await _teacherService.GetList();
            TeacherGrid.DataSource = teacher;
        }
        private async void NewTeacherBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewNameTeaxherText.Text))
            {
                var teacher = new Teacher
                {
                    Name = NewNameTeaxherText.Text
                };
                await _teacherService.Create(teacher);
                LoadTeacher();
            }
        }

        private void TeacherGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (TeacherGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectTeacherID = int.Parse(TeacherGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectTeacherID = 0;
                }


                UpdateNameTeacherText.Text = TeacherGrid.CurrentRow.Cells["Name"].Value?.ToString();

            }
        }

        private async void UpdateTeacherBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateNameTeacherText.Text))
            {
                var teacher = new Teacher
                {
                    Id = SelectTeacherID,
                    Name = UpdateNameTeacherText.Text
                };
                await _teacherService.Update(teacher);
                LoadTeacher();
            }
        }

        private async void DeleteTeacherBtn_Click(object sender, EventArgs e)
        {
            if (SelectTeacherID != 0)
            {
                var teacher = new Teacher
                {
                    Id = SelectTeacherID,

                };
                await _teacherService.Delete(teacher);
                LoadTeacher();
            }
        }

        private async void SearchTeachersText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTeachersText.Text))
            {
                try
                {
                   
                    TeacherGrid.DataSource = await _teacherService.Search(SearchTeachersText.Text);
                }
                catch (Exception)
                {
                    LoadTeacher();
                }


            }
            else
            {
                LoadTeacher();
            }
        }
    }
}
