using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
    public class GSM
    {
        //static field for Iphone7
        private static readonly GSM iPhone7 = new GSM("iPhone7", "Apple", 1640, new Battery("6800 mAh", 168, 24, Battery.Type.LiIon), new Display(1200, 800, 32000000));
        //call history field
        private readonly List<Call> callHistory = new List<Call>();
        //fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        //constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
        }
        //parameters from first constructor
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = null;
        }
        //parameters from second constructor
        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.owner = owner;
        }
        //with battery specs
        public GSM(string model, string manufacturer, Battery battery)
            : this(model, manufacturer)
        {
            this.Battery = battery;
        }
        //with display specs
        public GSM(string model, string manufacturer, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
        }
        //with everything no owner
        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
       : this(model, manufacturer, price)
        {
            this.Battery = battery;
            this.Display = display;
        }
        //with everything 
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
       : this(model, manufacturer, price)
        {
            this.owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //properties
        public Battery Battery { get; set; }

        public Display Display { get; set; }
        //iPhone static property
        public static GSM IPhone7
        {
            get
            {
                return iPhone7;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be empty.");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Field cannot be empty.");
                }

                manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price needs to be bigger then zero.");
                }
                price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Field cannot be empty.");
                }
                owner = value;
            }
        }
        //property to hold call history
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
        //add call
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        //deleting a call
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        //clear call history
        public void ClearAllCalls()
        {
            this.callHistory.Clear();
        }
        //calculate price for a call
        public decimal CallPrice(decimal perMinute)
        {
            decimal total = 0.0M;
            foreach (var call in this.callHistory)
            {
                total += call.Duration;
            }
            var totalPrice = perMinute * (total / 60.0M);
            return totalPrice;
        }
        //method  override ToString()
        public override string ToString()
        {
            var GSMinfo = new StringBuilder();
            GSMinfo.AppendLine("Mobile phone specifications");
            GSMinfo.AppendLine(new string('-', 40));
            GSMinfo.AppendLine("Model: " + this.model);
            GSMinfo.AppendLine();
            GSMinfo.AppendLine("Manufacturer: " + this.manufacturer);
            GSMinfo.AppendLine();

            if (this.price > 0)
            {
                GSMinfo.AppendLine("Price: " + this.price);
                GSMinfo.AppendLine();
            }
            if (!string.IsNullOrEmpty(this.owner))
            {
                GSMinfo.AppendLine("Owner: " + this.owner);
                GSMinfo.AppendLine();
            }

            if (this.Battery != null)
            {
                GSMinfo.AppendLine("Battery");
                GSMinfo.AppendLine();
                GSMinfo.AppendLine("   Model: " + this.Battery.BatteryModel);
                GSMinfo.AppendLine();
                GSMinfo.AppendLine("   Type: " + this.Battery.BatteryTypes);
                GSMinfo.AppendLine();

                if (this.Battery.HoursIdle != null) { }
                {
                    GSMinfo.AppendLine("   Hours Idle:" + this.Battery.HoursIdle);
                    GSMinfo.AppendLine();
                }
                if (this.Battery.HoursTalk != null) { }
                {
                    GSMinfo.AppendLine("   Hours Talk:" + this.Battery.HoursTalk);
                    GSMinfo.AppendLine();
                }
            }
            if (Display != null)
            {
                GSMinfo.AppendLine("Display");
                GSMinfo.AppendLine();
                if (this.Display.DisplayHeigth > 0 && this.Display.DisplayWidth > 0)
                {
                    GSMinfo.AppendLine("   Size " + this.Display.DisplayHeigth + "x" + this.Display.DisplayWidth);
                    GSMinfo.AppendLine();
                }
                if (this.Display.DisplayColors > 0)
                {
                    GSMinfo.AppendLine("   Colors " + this.Display.DisplayColors);
                }
            }
            GSMinfo.AppendLine();
            return GSMinfo.ToString();
        }
    }
}
