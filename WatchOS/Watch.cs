using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WatchOS
{
    public partial class Watch : Form
    {
        private Time time;
        private Imgur imgur;

        enum Mode
        {
            time, imgur
        }

        private Mode currentMode;

        private Stopwatch button1Stopwatch;
        private Stopwatch button2Stopwatch;

        private Timer button1Timer;
        private Timer button2Timer;

        private int button1Clicks = 0;
        private int button2Clicks = 0;

        public Watch()
        {
            InitializeComponent();

            button1Stopwatch = new Stopwatch();
            button2Stopwatch = new Stopwatch();

            button1Timer = new Timer(200);
            button1Timer.Elapsed += (sender, args) =>
            {
                if (button1Clicks >= 2)
                {
                    buttonTwice(1);
                }

                button1Clicks = 0;
            };
            button1Timer.Start();

            button2Timer = new Timer(200);
            button2Timer.Elapsed += (sender, args) =>
            {
                if (button2Clicks >= 2)
                {
                    buttonTwice(2);
                }

                button2Clicks = 0;
            };
            button2Timer.Start();

            currentMode = Mode.time; // Init to start with time
            time = new Time();
            time.Show();

            imgur = new Imgur(); // Load imgur on background
            imgur.Hide();
            //imgur.LoadPosts();
        }

        public void button1Down(object sender, MouseEventArgs e)
        {
            button1Timer.Stop();
            button1Timer.Start();

            if (button1Stopwatch.IsRunning)
            {
                button1Stopwatch.Restart();
            }
            else
            {
                button1Stopwatch.Start();
            }
            
        }

        public void button1Up(object sender, MouseEventArgs e)
        {
            button1Clicks++;

            if (button1Stopwatch.ElapsedMilliseconds >= 500)
            {
                buttonLong(1);
                button1Stopwatch.Stop();
                button1Stopwatch.Reset();
                button1Clicks = 0;
            }
            else if (button1Stopwatch.ElapsedMilliseconds >= 100)
            {
                buttonShort(1);
                button1Stopwatch.Stop();
                button1Stopwatch.Reset();
                button1Clicks = 0;
            }
        }

        public void button2Down(object sender, MouseEventArgs e)
        {
            button2Timer.Stop();
            button2Timer.Start();

            if (button2Stopwatch.IsRunning)
            {
                button2Stopwatch.Restart();
            }
            else
            {
                button2Stopwatch.Start();
            }
        }

        public void button2Up(object sender, MouseEventArgs e)
        {
            button2Stopwatch.Stop();

            if (button2Stopwatch.ElapsedMilliseconds >= 200)
            {
                buttonLong(2);
            }
            else
            {
                buttonShort(2);
            }
        }

        private void changeWatchMode()
        {
            if (currentMode == Mode.time)
            {
                time.Hide();
                imgur.Show();
                currentMode = Mode.imgur;
            }
            else
            {
                imgur.Hide();
                time.Show();
                currentMode = Mode.time;
            }
        }

        private void buttonShort(int buttonNo)
        {
            Console.WriteLine("Button " + buttonNo + " short");
            switch (buttonNo)
            {
                case 1:
                    if (currentMode == Mode.time)
                    {
                        
                    }
                    else
                    {
                        
                    }
                    break;
                case 2:
                    if (currentMode == Mode.time)
                    {
                        
                    }
                    else
                    {
                        
                    }
                    break;
            }
        }

        private void buttonLong(int buttonNo)
        {
            Console.WriteLine("Button " + buttonNo + " long");
            switch (buttonNo)
            {
                case 1:
                    if (currentMode == Mode.time)
                    {

                    }
                    else
                    {

                    }
                    break;
                case 2:
                    if (currentMode == Mode.time)
                    {

                    }
                    else
                    {

                    }
                    break;
            }
        }

        private void buttonTwice(int buttonNo)
        {
            Console.WriteLine("Button " + buttonNo + " twice");
        }

        public void buttonBoth(object sender, MouseEventArgs e)
        {
            changeWatchMode();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
