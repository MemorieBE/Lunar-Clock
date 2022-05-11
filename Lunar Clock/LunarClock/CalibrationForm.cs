using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunarClock
{
    public partial class CalibrationForm : Form
    {
        public ClockForm mainForm;

        public CalibrationForm()
        {
            InitializeComponent();
        }

        private void CalibrationForm_Load(object sender, EventArgs e)
        {
            lunarComboBox.SelectedIndex = 0;
            lunarDatePicker.MinDate = DateTime.Today.AddDays(-30);
            lunarDatePicker.MaxDate = DateTime.Today.AddDays(30);
        }

        private void lunarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lunarComboBox.SelectedIndex)
            {
                case 0:
                    moonDisplayImage.BackgroundImage = Properties.Resources.New_Moon;
                    break;
                case 1:
                    moonDisplayImage.BackgroundImage = Properties.Resources.First_Quater;
                    break;
                case 2:
                    moonDisplayImage.BackgroundImage = Properties.Resources.Full_Moon;
                    break;
                case 3:
                    moonDisplayImage.BackgroundImage = Properties.Resources.Third_Quater;
                    break;
            }
        }

        private void calibrationButton_Click(object sender, EventArgs e)
        {
            DateTime newDateTime = lunarDatePicker.Value.Date + lunarTimePicker.Value.TimeOfDay;

            switch (lunarComboBox.SelectedIndex)
            {
                case 0:
                    ClockForm.lastNewMoon = newDateTime.AddDays(-ClockForm.avgLunarCycle);
                    break;
                case 1:
                    ClockForm.lastNewMoon = newDateTime.AddDays(-ClockForm.avgLunarCycle * (DateTime.Now > newDateTime.AddDays(-ClockForm.avgLunarCycle * 0.25f) ? 0.25f : 1.25));
                    break;
                case 2:
                    ClockForm.lastNewMoon = newDateTime.AddDays(-ClockForm.avgLunarCycle * (DateTime.Now > newDateTime.AddDays(-ClockForm.avgLunarCycle * 0.5f) ? 0.5f : 1.5));
                    break;
                case 3:
                    ClockForm.lastNewMoon = newDateTime.AddDays(-ClockForm.avgLunarCycle * (DateTime.Now > newDateTime.AddDays(-ClockForm.avgLunarCycle * 0.75f) ? 0.75f : 1.75));
                    break;
            }

            mainForm.LoadLunarAssets();

            this.Close();
        }
    }
}
