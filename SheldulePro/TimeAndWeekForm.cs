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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SheldulePro
{
    public partial class TimeAndWeekForm : Form
    {
        private readonly ClassTimeService _timeService = new ClassTimeService();
        private readonly WeekService _weekService = new WeekService();
        private int SelectTimeID = 0;

        public TimeAndWeekForm()
        {
            InitializeComponent();
            LoadTime();
        }
        private async void LoadTime()
        {
            TimeGrid.DataSource = await _timeService.GetList();
        }

        private async void NewTimeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewTimeText.Text))
            {
                var time = new ClassTime
                {

                    Number = int.Parse(NewTimeText.Text),
                    StartTime = NewStartTimePicker.Value.TimeOfDay,
                    EndTime = NewEndTimePicker.Value.TimeOfDay

                };
                await _timeService.Create(time);
                LoadTime();
            }
        }

        private async void SearchTimeText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTimeText.Text))
            {
                try
                {
                    var num = int.Parse(SearchTimeText.Text);
                    TimeGrid.DataSource = await _timeService.Search(num);
                }
                catch (Exception)
                {
                    LoadTime();
                }


            }
            else
            {
                LoadTime();
            }
        }

        private void TimeGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (TimeGrid.CurrentRow != null)
            {
                // Получаем значения из текущей строки
                try
                {
                    SelectTimeID = int.Parse(TimeGrid.CurrentRow.Cells["Id"].Value?.ToString());
                }
                catch (Exception)
                {

                    SelectTimeID = 0;
                }


                UpdateTimeText.Text = TimeGrid.CurrentRow.Cells["Number"].Value?.ToString();
                UpdateStartTimePicker.Value = DateTime.Parse(TimeGrid.CurrentRow.Cells["StartTime"].Value?.ToString());
                UpdateEndTimePicker.Value = DateTime.Parse(TimeGrid.CurrentRow.Cells["EndTime"].Value?.ToString());
            }
        }

        private async void UpdateTimeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UpdateTimeText.Text))
            {
                var time = new ClassTime
                {
                    Id = SelectTimeID,
                    Number = int.Parse(UpdateTimeText.Text),
                    StartTime = UpdateStartTimePicker.Value.TimeOfDay,
                    EndTime = UpdateEndTimePicker.Value.TimeOfDay

                };
                await _timeService.Update(time);
                LoadTime();
            }
        }

        private async void DeleteTimeBtn_Click(object sender, EventArgs e)
        {
            if (SelectTimeID != 0)
            {
                var time = new ClassTime
                {
                    Id = SelectTimeID

                };
                await _timeService.Delete(time);
                LoadTime();
            }
        }
    }
}
