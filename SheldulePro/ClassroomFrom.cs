using Sheldule.Application;
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
    public partial class ClassroomFrom : Form
    {
        private readonly ClassroomService _classroomService = new ClassroomService();
        private int SelectedRoomID = 0;
        public ClassroomFrom()
        {
            InitializeComponent();
            LoadRoom();
        }

        private async void LoadRoom()
        {
            var room = await _classroomService.GetList();
            RoomGrid.DataSource = room;
        }

        private async void NewRoomBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewNumberText.Text) || !string.IsNullOrEmpty(NewTypeText.Text))
            {
                var room = new Classroom
                {
                    Number = NewNumberText.Text,
                    Type = NewTypeText.Text,
                };
                await _classroomService.Create(room);
                LoadRoom();
            }
        }

        private void RoomGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectedRoomID = int.Parse(RoomGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectedRoomID = 0;
                }


                UpdateNumberText.Text = RoomGrid.CurrentRow.Cells["Number"].Value?.ToString();
                UpdateTypeText.Text = RoomGrid.CurrentRow.Cells["Type"].Value?.ToString();

            }
        }

        private async void UpdateRoomBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateNumberText.Text) || !string.IsNullOrEmpty(UpdateTypeText.Text))
            {
                var room = new Classroom
                {
                    Id = SelectedRoomID,
                    Number = UpdateNumberText.Text,
                    Type = UpdateTypeText.Text,
                };
                await _classroomService.Update(room);
                LoadRoom();
            }
        }

        private async void DeleteRoomBtn_Click(object sender, EventArgs e)
        {
            if (SelectedRoomID != 0)
            {
                var room = new Classroom
                {
                    Id = SelectedRoomID,

                };
                await _classroomService.Delete(room);
                LoadRoom();
            }
        }

        private async void SearchRoomText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchRoomText.Text))
            {
                try
                {

                    RoomGrid.DataSource = await _classroomService.Search(SearchRoomText.Text);
                }
                catch (Exception)
                {
                    LoadRoom();
                }


            }
            else
            {
                LoadRoom();
            }
        }
    }
}
