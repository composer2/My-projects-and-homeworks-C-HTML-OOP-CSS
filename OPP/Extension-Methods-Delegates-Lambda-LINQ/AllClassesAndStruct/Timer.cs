namespace AllClassesAndStruct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public delegate void TimerEvent(int param);
    public class Timer
    {
        private TimerEvent timerEvent;
        private int miliSeconds;
        private int ticks;

        public Timer(int miliSeconds, TimerEvent timerEvent)
        {
            this.miliSeconds = miliSeconds;
            this.timerEvent = timerEvent;
        }

        public Timer(int miliSeconds, TimerEvent timerEvent, int ticks)
            : this(miliSeconds, timerEvent)
        {
            this.ticks = ticks;
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ticks value must be greater than zero.");
                }

                this.ticks = value;
            }
        }
        public int MiliSeconds
        {
            get
            {
                return this.miliSeconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ticks value must be greater than zero.");
                }

                this.miliSeconds = value * 1000;
            }
        }
        public TimerEvent TimerEvent
        {
            get
            {
                return this.timerEvent;
            }
            set
            {
                this.timerEvent = value;
            }
        }

        public void ExecuteTask()
        {
            while (this.ticks < this.miliSeconds)
            {
                Thread.Sleep(this.miliSeconds);
                this.ticks++;
                this.TimerEvent(this.miliSeconds);
            }
        }
    }
}
