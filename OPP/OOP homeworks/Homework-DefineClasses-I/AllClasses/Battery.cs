using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
   public class Battery
    {
        //fields
        private string batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;
        private Type batteryType;

        public enum Type
        {
            LiIon,
            NiMH,
            NiCd
        }

        //Constructors
        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;
            this.hoursIdle = null;
            this.hoursTalk = null;
        }
        //parameters from first constructor
        public Battery(string batteryModel, int hoursIdle)
            : this(batteryModel)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = null;
        }
        //parameters from second constructor
        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
            : this(batteryModel, hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }
        //parameters from second constructor
        public Battery(string batteryModel, int hoursIdle, int hoursTalk, Type batteryType)
        : this(batteryModel, hoursIdle, hoursTalk)
        {
            this.batteryType = batteryType;
        }
        //properties
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be empty.");
                }
                batteryModel = value;
            }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Field needs to be bigger then zero.");
                }
                hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Field needs to be bigger then zero.");
                }
                hoursTalk = value;
            }
        }
        public Type BatteryTypes
        {
            get { return this.batteryType; }
        }
    }
}
