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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Down(object sender, MouseEventArgs e)
        {
            button1Timer.Enabled = true;
            if (doubleClickTimer.Enabled)
            {
                //timer staat al aan: doubleclicked!
                 System.Diagnostics.Debug.WriteLine("double clicked button 1");
            }
              doubleClickTimer.Enabled = true;
        }

        private void Button1Up(object sender, MouseEventArgs e)
        {
            button1Timer.Enabled = false;
        }

        private void Button2Down(object sender, MouseEventArgs e)
        {
            button2Timer.Enabled = true;
            
            if (doubleClickTimer.Enabled)
            {
                //timer staat al aan: doubleclicked!
                System.Diagnostics.Debug.WriteLine("double clicked btn 2");
            }
            doubleClickTimer.Enabled = true;
        }

        private void Button2Up(object sender, MouseEventArgs e)
        {
            button2Timer.Enabled = false;
        }

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

        private void button1Timer_Tick(object sender, EventArgs e)
        {
            button1Timer.Enabled = false;
             System.Diagnostics.Debug.WriteLine("button 1 long clicked!");
            //buttonLong(1);
        }

        private void button2Timer_Tick(object sender, EventArgs e)
        {
            button1Timer.Enabled = false;
            System.Diagnostics.Debug.WriteLine("button 2 long clicked!");
            //buttonLong(1);
        }

        private void doubleClickTimer_Tick(object sender, EventArgs e)
        {
            doubleClickTimer.Enabled = false;

           //  System.Diagnostics.Debug.WriteLine("timer reset");
        }
    }
}
