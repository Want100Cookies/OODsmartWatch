using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WatchOS
{
    class Time
    {
        private int minutes;
        private int hours;
        private enum Mode { view, changeMinutes, changeHours}
       
        private Mode currentMode;

        public Time()
        {
            minutes = DateTime.Now.Minute;
            hours = DateTime.Now.Hour;
            currentMode = Mode.view;
        }
 
        public String getMinutes()
        {
            return minutes.ToString("00");
        }

        public String getHours()
        {
            return hours.ToString("00");
        }

        public void changeTimeMode()
        {
            //note: iets met currentMode.getNext() was er niet standaard in c#.
            switch (currentMode)
            {
                case Mode.view:
                    currentMode = Mode.changeHours;
                    break;
                case Mode.changeHours:
                    currentMode = Mode.changeMinutes;
                    break;
                case Mode.changeMinutes:
                    currentMode = Mode.view;
                    break;
            }
            Debug.WriteLine("Current mode switched to: " + currentMode.ToString());
        }

        //this is a bit.....
        public String getMode()
        {
            switch (currentMode)
            {
                case Mode.view:
                    return "view";
                case Mode.changeHours:
                    return "changeHours";
                case Mode.changeMinutes:
                    return "changeMinutes";
            }
            return "unknown";
        }

        /// <summary>
        /// methdode die wordt gebruikt om de tijd te verhogen wanneer deze in de 'verander modus' is
        /// </summary>
        public void incrementTime()
        {
            if (currentMode == Mode.changeHours)
            {
                hours++;

            }
            else
            {
                minutes++;
            }
            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }
        }

        public void tick()
        {
            //dubble code: please fix wizzard
            minutes++;
            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }
            if (hours > 23)
            {
                hours = 0;
            }
        }
    }

}
