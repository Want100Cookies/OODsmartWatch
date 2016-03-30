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

        private int button1Clicks = 0;
        private int button2Clicks = 0;

        public Watch()
        {
            InitializeComponent();

            currentMode = Mode.time; // Init to start with time
            time = new Time();
            time.Show();

            imgur = new Imgur(); // Load imgur on background
            imgur.Hide();
            //imgur.LoadPosts();
        }

        public void button1Down(object sender, MouseEventArgs e)
        {
            if (button1Clicks == 0)
            {
                button1Stopwatch.Restart();
            }
        }

        public void button1Up(object sender, MouseEventArgs e)
        {
            if (button1Stopwatch.ElapsedMilliseconds >= 200)
            {
                buttonLong(1);
                button1Stopwatch.Stop();
            }
            else if (button1Stopwatch.ElapsedMilliseconds <= 50)
            {
                button1Clicks++;
                button1Stopwatch.Restart();

                if (button1Clicks >= 2)
                {
                    buttonTwice(1);
                    button1Stopwatch.Stop();
                }
            }
        }

        public void button2Down(object sender, MouseEventArgs e)
        {
            button2Stopwatch.Restart();
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
            switch (buttonNo)
            {
                    
            }
        }

        private void buttonLong(int buttonNo)
        {
            switch (buttonNo)
            {

            }
        }

        private void buttonTwice(int buttonNo)
        {
            
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
