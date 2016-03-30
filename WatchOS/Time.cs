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
            hours = 23;
            minutes = 12;
            InitializeComponent();
            currentMode = Mode.changeMinutes;
            changeTimeMode();
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
                lblCurrentMode.Text = "Change minutes";
            }
            else if(currentMode == Mode.changeMinutes)
            {
                currentMode = Mode.view;
                lblCurrentMode.Text = "View";
            }
            else if (currentMode == Mode.view)
            {
                currentMode = Mode.changeHours;
                lblCurrentMode.Text = "Change hours";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            incrementMinutes();
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }

        public void incrementTime()
        {
            if (currentMode == Mode.changeHours)
            {
                incrementHours();
            } else if (currentMode == Mode.changeMinutes)
            {
                incrementMinutes();
            }
        }

        private void incrementHours()
        {
            hours++;

            if (hours > 23)
            {
                hours = 00;
            }

            if (hours < 10)
            {
                label2.Text = "0" + hours.ToString();
            }
            else
            {
                label2.Text = hours.ToString();
            }
        }

        private void incrementMinutes()
        {
            minutes++; 

            if (minutes > 59)
            {
                minutes = 00;
                incrementHours();
            }

            if (minutes < 10)
            {
                label3.Text = "0" + minutes.ToString();

            }
            else
            {
                label3.Text = minutes.ToString();
            }
        }
    } 
}

