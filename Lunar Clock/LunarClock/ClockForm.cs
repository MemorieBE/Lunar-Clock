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
    public partial class ClockForm : Form
    {
        public const double avgLunarCycle = 29.53058770576;

        private const float eventLength = 1f;

        private int lunarPhaseIndex = 0;
        private string[] lunarPhases = new string[] 
        { 
            "New Moon",
            "Waxing Crescent",
            "First Quater",
            "Waxing Gibbous",
            "Full Moon",
            "Waning Gibbous",
            "Third Quater",
            "Waning Crescent"
        };
        private string[] lunarDescriptions = new string[]
        {
            Properties.Resources.New_Moon_Description,
            Properties.Resources.Waxing_Crescent_Description,
            Properties.Resources.First_Quater_Description,
            Properties.Resources.Waxing_Gibbous_Description,
            Properties.Resources.Full_Moon_Description,
            Properties.Resources.Waning_Gibbous_Description,
            Properties.Resources.Third_Quater_Description,
            Properties.Resources.Waning_Crescent_Description
        };

        private DateTime currentTime;
        private Timer timer;

        public static DateTime? lastNewMoon = null;

        private Image lunarCycleImage;

        private int currentSecond = 0;

        public ClockForm()
        {
            InitializeComponent();
        }

        private void ClockForm_Load(object sender, EventArgs e)
        {
            lunarCycleImage = lunarCyclePB.BackgroundImage;

            if (LunarSettings.Default.hasMoonDataS) 
            { 
                lastNewMoon = LunarSettings.Default.lastNewMoonS;

                LoadLunarAssets();
            }
            else
            {
                OpenCalibration();
            }
        }

        public void LoadLunarAssets()
        {
            SetUpTimer();

            while ((currentTime - lastNewMoon.Value).TotalDays > avgLunarCycle || (lastNewMoon.Value - currentTime).TotalDays > avgLunarCycle)
            {
                lastNewMoon = lastNewMoon.Value.AddDays(lastNewMoon < currentTime ? avgLunarCycle : -avgLunarCycle);
            }

            LunarSettings.Default.lastNewMoonS = lastNewMoon.Value;
            LunarSettings.Default.hasMoonDataS = true;
            LunarSettings.Default.Save();

            float lunarFraction = (float)(currentTime - lastNewMoon.Value).TotalDays / (float)avgLunarCycle;
            lunarPhaseIndex = 0;

            UpdateLunarDetails(lunarFraction);

            lunarCyclePB.BackgroundImage = RotateImage(lunarCycleImage, lunarFraction * 360f);

            ChangeDescription(lunarPhaseIndex - 1);
        }

        private void OpenCalibration()
        {
            Form calForm = new CalibrationForm();
            ((CalibrationForm)calForm).mainForm = this;
            calForm.Show();
            calForm.TopMost = true;
        }

        private void EstablishTime(DateTime dateTime)
        {
            currentTime = dateTime;
            timeText.Text = currentTime.ToString("h:mm:ss tt") + "\n" + currentTime.ToString("d MMMM yyyy");
        }

        private void SetUpTimer()
        {
            EstablishTime(DateTime.Now);
            currentSecond = currentTime.Second;

            timer = new Timer();
            timer.Interval = 1000 - currentTime.Millisecond;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentSecond == DateTime.Now.Second)
            {
                EstablishTime(DateTime.Now.AddSeconds(1));

                timer.Interval = 2000 - currentTime.Millisecond;
            }
            else
            {
                EstablishTime(DateTime.Now);

                timer.Interval = 1000 - currentTime.Millisecond;
            }

            currentTime.AddMilliseconds(-currentTime.Millisecond);

            currentSecond = currentTime.Second;

            if (currentTime.Second == 0)
            {
                float lunarFraction = (float)(currentTime - lastNewMoon.Value).TotalDays / (float)avgLunarCycle;

                UpdateLunarDetails(lunarFraction);

                if (currentTime.Minute / 10f == Math.Round(currentTime.Minute / 10f))
                {
                    lunarCyclePB.BackgroundImage = RotateImage(lunarCycleImage, lunarFraction * 360f);
                }
            }
        }

        private void UpdateLunarDetails(float lunarFraction)
        {
            float lunarPercentage = (lunarFraction < 0.5f ? lunarFraction / 2f : (1f - lunarFraction) / 2f) * 100f;

            lunarLuminanceText.Text = "Luminance: " + lunarPercentage.ToString("F") + "%";

            int newIndex = lunarPhaseIndex;
            float eventOffset = eventLength / (float)avgLunarCycle / 2f;

            switch (lunarPhaseIndex)
            {
                case 0:
                    LunarPhaseCheck(lunarFraction, out newIndex);
                    break;
                case 1:
                    if (lunarFraction > eventOffset && lunarFraction < 1f - eventOffset)
                    {
                        newIndex = 2;
                    }
                    break;
                case 2:
                    if (lunarFraction >= 0.25f - eventOffset || lunarFraction <= eventOffset)
                    {
                        newIndex = 3;
                    }
                    break;
                case 3:
                    if (lunarFraction > 0.25f + eventOffset || lunarFraction < 0.25f - eventOffset)
                    {
                        newIndex = 4;
                    }
                    break;
                case 4:
                    if (lunarFraction >= 0.5f - eventOffset || lunarFraction <= 0.25f + eventOffset)
                    {
                        newIndex = 5;
                    }
                    break;
                case 5:
                    if (lunarFraction > 0.5f + eventOffset || lunarFraction < 0.5f - eventOffset)
                    {
                        newIndex = 6;
                    }
                    break;
                case 6:
                    if (lunarFraction >= 0.75f - eventOffset || lunarFraction <= 0.5f + eventOffset)
                    {
                        newIndex = 7;
                    }
                    break;
                case 7:
                    if (lunarFraction > 0.75f + eventOffset || lunarFraction < 0.75f - eventOffset)
                    {
                        newIndex = 8;
                    }
                    break;
                case 8:
                    if (lunarFraction >= 1f - eventOffset || lunarFraction <= 0.75f + eventOffset)
                    {
                        newIndex = 1;
                    }
                    break;
            }

            if (lunarPhaseIndex != newIndex)
            {
                lunarPhaseIndex = newIndex;
                lunarPhaseText.Text = lunarPhases[newIndex - 1];
            }

            DateTime moonPeak = lastNewMoon.Value.AddDays((lunarPhaseIndex - 1) / 8f * avgLunarCycle);
            lunarPeakTimeText.Text = "Peak Time: " + moonPeak.ToShortTimeString();
            lunarPeakDateText.Text = "Peak Date: " + moonPeak.ToShortDateString();
        }

        private void LunarPhaseCheck(float lunarFraction, out int newIndex)
        {
            newIndex = 0;
            float eventOffset = eventLength / (float)avgLunarCycle / 2f;

            if (lunarFraction > eventOffset && lunarFraction < 0.25f - eventOffset)
            {
                newIndex = 2;
            }
            else if (lunarFraction > 0.25f + eventOffset && lunarFraction < 0.5f - eventOffset)
            {
                newIndex = 4;
            }
            else if (lunarFraction > 0.5f + eventOffset && lunarFraction < 0.75f - eventOffset)
            {
                newIndex = 6;
            }
            else if (lunarFraction > 0.75f + eventOffset && lunarFraction < 1f - eventOffset)
            {
                newIndex = 8;
            }
            else if (lunarFraction >= 1f - eventOffset || lunarFraction <= eventOffset)
            {
                newIndex = 1;
            }
            else if (lunarFraction >= 0.25f - eventOffset && lunarFraction <= 0.25f + eventOffset)
            {
                newIndex = 3;
            }
            else if (lunarFraction >= 0.5f - eventOffset && lunarFraction <= 0.5f + eventOffset)
            {
                newIndex = 5;
            }
            else if (lunarFraction >= 0.75f - eventOffset && lunarFraction <= 0.75f + eventOffset)
            {
                newIndex = 7;
            }
        }

        private void ChangeDescription(int index)
        {
            moonTitleText.Text = lunarPhases[index];
            moonDescriptionText.Text = lunarDescriptions[index];
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            Graphics g = Graphics.FromImage(rotatedBmp);

            g.TranslateTransform(image.Width / 2, image.Height / 2);

            g.RotateTransform(angle);

            g.TranslateTransform(-image.Width / 2, -image.Height / 2);

            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void recalibrationButton_Click(object sender, EventArgs e)
        {
            OpenCalibration();
        }

        private void sourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.timeanddate.com/moon/phases/");
        }
    }
}
