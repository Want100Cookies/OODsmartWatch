using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Timer button1Timer;
        private Timer button2Timer;

        public Watch()
        {
            InitializeComponent();
        }
    }
}
