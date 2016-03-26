using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* note: je kan button 1 niet dubbel klikken. 
*/

namespace WatchOS
{
    public partial class Form1 : Form
    {
        private Time time;
        private Imgur imgur;

        private enum Mode{time, imgur};

        private Mode currentMode;
        
        public Form1()
        {
            InitializeComponent();
            time = new Time();
            imgur = new Imgur();
            currentMode = Mode.time;

            updateTime();
        }

        private void updateTime()
        {
            labelTime.Text = time.getHours() + ":" + time.getMinutes();
        }

        #region ButtonEvents

        private void Button1Down(object sender, MouseEventArgs e)
        {
            button1Timer.Enabled = true;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2Timer.Enabled = true;

            if (doubleClickTimer.Enabled)
            {
                //timer staat al aan: doubleclicked!
                Debug.WriteLine("double clicked btn 2");
                buttonTwice(2);
                doubleClickTimer.Stop();
                doubleClickTimer.Enabled = false;
                button2Timer.Enabled = false;
            }
            else
            {
                doubleClickTimer.Enabled = true;
            }
        }

        private void Button1Up(object sender, MouseEventArgs e)
        {
            if (button1Timer.Enabled)
            {
                Debug.WriteLine("normal clicked button 1");
                buttonShort(1);
            }

            button1Timer.Enabled = false;
        }

        private void Button2Up(object sender, MouseEventArgs e)
        {
            button2Timer.Enabled = false;
        }

        #endregion


        #region button actions

        private void changeWatchMode()
        {

        }

        private void buttonShort(int buttonNo)
        {

        }

        private void buttonLong(int buttonNo)
        {

        }

        private void buttonTwice(int buttonNo)
        {
            
        }



        #endregion

        #region Timers
        private void button1Timer_Tick(object sender, EventArgs e)
        {
            button1Timer.Enabled = false;
            System.Diagnostics.Debug.WriteLine("button 1 long clicked!");
            buttonLong(1);
        }

        private void button2Timer_Tick(object sender, EventArgs e)
        {
            button2Timer.Enabled = false;
            System.Diagnostics.Debug.WriteLine("button 2 long clicked!");
            buttonLong(2);
        }

        private void doubleClickTimer_Tick(object sender, EventArgs e)
        {
            doubleClickTimer.Enabled = false;
            if (!button2Timer.Enabled)
            {
                System.Diagnostics.Debug.WriteLine("clicked button 2");
                buttonShort(2);
            }


            //   System.Diagnostics.Debug.WriteLine("timer reset");
        } 
        #endregion
    }
}
