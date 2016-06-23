using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    internal class AlarmClock
    {
        private int hours = 9;
        private int minutes = 0;

        public AlarmClock()
        {
        }

        public AlarmClock(int h, int m)
        {
            this.hours = h;
            this.minutes = m;
        }

        public int Hours { get { return this.hours; } set {this.hours=value; } }
        public int Minutes { get { return this.minutes; } set { this.minutes = value; } }
    }
}
