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
    public partial class formTime : Form
    {
        private Time time;
        private Imgur imgur;

        private enum Mode{time, imgur};

        private Mode currentMode;
        
        public formTime()
        {
            InitializeComponent();
            time = new Time();
            imgur = new Imgur();
            currentMode = Mode.time;

            //1 minuut:
            //timerKlok.Interval = 60000;

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
            if (currentMode == Mode.time)
            {
                currentMode = Mode.imgur;
            }
            else
            {
                currentMode = Mode.time;
            }
            Debug.WriteLine("current mode is now " + currentMode);
        }

        /// <summary>
        /// button wordt short ingedrukt
        /// </summary>
        /// <param name="buttonNo"></param>
        private void buttonShort(int buttonNo)
        {
            if (currentMode == Mode.time)
            {
                //change time:
                switch (buttonNo)
                {
                    case 1:
                        if (time.getMode() != "view")
                        {
                            time.incrementTime();
                            updateTime();
                        }
                        break;
                    case 2:
                        time.changeTimeMode();
                        break;
                    default:
                        throw new NotImplementedException("Fout in switch case statement: switch buttonNo");
                }
            }
            else
            {
                //imgur app:
                switch (buttonNo)
                {
                    case 1:
                        changeWatchMode();
                        break;
                    case 2:
                        time.changeTimeMode();
                        break;
                    default:
                        throw new NotImplementedException("Fout in switch case statement: switch buttonNo");
                }
            }
        }

        private void buttonLong(int buttonNo)
        {
            switch (buttonNo)
            {
                case 1:
                    break;
                case 2:
                    break;
            }

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

        private void timerKlok_Tick(object sender, EventArgs e)
        {
            clockTick();
        }

        /// <summary>
        /// Methode die wordt aangeroepen als er een minuut is verstreken.
        /// </summary>
        private void clockTick()
        {
            time.tick();
            updateTime();
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            changeWatchMode();
        }
    }
}
