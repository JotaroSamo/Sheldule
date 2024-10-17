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
    public partial class GroupForm : Form
    {
        private readonly StudentGroupService _studentGroupService = new StudentGroupService();
        private int SelectedGroupID = 0;
        private readonly Main _main;
        public GroupForm(Main main)
        {
            InitializeComponent();
            Style.ApplyGlobalStyles(this.Controls);
            Style.ApplyFormBackground(this);
            LoadGroup();
            _main = main;
        }
        private async void LoadGroup()
        {
            var group = await _studentGroupService.GetList();
            GroupGrid.DataSource = group;
        }

        private async void NewGroupBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewGroupText.Text))
            {
                var group = new StudentGroup
                {
                    Name = NewGroupText.Text,
                };
                await _studentGroupService.Create(group);
                LoadGroup();
                await _main.LoadComboBoxesAsync();
            }
        }

        private void GroupGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (GroupGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectedGroupID = int.Parse(GroupGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectedGroupID = 0;
                }


                UpdateGroupText.Text = GroupGrid.CurrentRow.Cells["Name"].Value?.ToString();

            }
        }

        private async void UpdateGroupBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateGroupText.Text))
            {
                var group = new StudentGroup
                {
                    Id = SelectedGroupID,
                    Name = UpdateGroupText.Text,
                };
                await _studentGroupService.Update(group);
                LoadGroup();
                await _main.LoadComboBoxesAsync();
            }
        }

        private async void DeleteGroupBtn_Click(object sender, EventArgs e)
        {
            if (SelectedGroupID != 0)
            {
                var group = new StudentGroup
                {
                    Id = SelectedGroupID,

                };
                await _studentGroupService.Delete(group);
                LoadGroup();
                await _main.LoadComboBoxesAsync();
            }
        }

        
        private async void SearchGroupText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchGroupText.Text))
            {
                try
                {

                    GroupGrid.DataSource = await _studentGroupService.Search(SearchGroupText.Text);
                }
                catch (Exception)
                {
                    LoadGroup();
                }


            }
            else
            {
                LoadGroup();
            }
        }
    }
}
