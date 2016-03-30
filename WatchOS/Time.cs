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

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (minutes > 59)
                {
                    minutes = 00;
                    hours++;
                     
                }
                else if (hours > 23)
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

            if (minutes < 10)
            {
                label3.Text = "0" + minutes.ToString();

            }
            else
            {
                label3.Text = minutes.ToString();
            }
            minutes++;
            }

        private void Time_Load(object sender, EventArgs e)
        {

        }
    } 
    }

