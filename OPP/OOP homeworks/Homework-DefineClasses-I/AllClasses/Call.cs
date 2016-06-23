using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
    public class Call
    {
        //fields
        private DateTime dateTime;
        private string phoneNumber;
        private int duration;
        //constructor
        public Call(string phoneNumber, int duration)
        {
            this.dateTime = DateTime.Now;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }
        //properties
        public DateTime Datetime
        {
            get
            {
                if (this.dateTime.Equals(null))
                {
                    throw new NullReferenceException("Date and time of call should not be empty");
                }
                return this.dateTime;
            }
            private set { this.dateTime = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Number must not be null or empty.");
                }
                this.phoneNumber = value;
            }
        }
        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Call duration must be at least a second");
                }
                this.duration = value;
            }
        }
        //methods
        public override string ToString()
        {
            var callsInfo = new StringBuilder();
            callsInfo.AppendLine("Call Log:");
            callsInfo.AppendLine(new string('-', 40));
            callsInfo.AppendLine("This number called : " + this.phoneNumber);
            callsInfo.AppendLine();
            callsInfo.AppendFormat("Made on: {0} at {1}", this.dateTime.ToShortDateString(), this.dateTime.ToShortTimeString());
            callsInfo.AppendLine();
            callsInfo.AppendFormat("Duration: {0:F2} seconds", this.duration);
            return callsInfo.ToString();
        }
    }
}
