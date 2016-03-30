using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchOS
{
    public partial class Time : Form
    {
        private int minutes;
        private int hours;
        private enum Mode {view, changeMinutes, changeHours};
        private Mode currentMode;

        public Time()
        {
            hours = 10;
            minutes = 10;
            InitializeComponent();
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }
        public String getMinutes()
        {
            return minutes.ToString();
        }
        public String getHours()
        {
            return hours.ToString();
        }
        public void changeTimeMode()
        {
            if(currentMode == Mode.changeHours)
            {
                currentMode = Mode.changeMinutes;
            }
            else if(currentMode == Mode.changeMinutes)
            {
                currentMode = Mode.view;
            }
            else if (currentMode == Mode.view)
            {
                currentMode = Mode.changeHours;
            }
        }

        public void incrementTime()
        {
            if(currentMode == Mode.changeHours)
            {
                hours++;
            }
            else if(currentMode == Mode.changeMinutes)
            {
                minutes++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = hours.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = minutes.ToString();
        }
    }
}
