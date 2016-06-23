using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningConstructors
{
    public class Point
    {
        private int xCood;
        private int yCood;
        private string name;
        //simple parameters constructor
        public Point() : this(0, 0)// Reuse the constructor
        {
        }

        public Point(int xCood, int yCood)
        {
            this.xCood = xCood;
            this.yCood =yCood;
            this.name = string.Format("Point({0},{1})", xCood, yCood);
        }
        public int XCood
        {
            get { return this.xCood; }
            set { this.xCood = value; }
        }
        public int YCood
        {
            get { return this.yCood; }
            set { this.yCood = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //method
        public double CalcDistance(Point p)
        {
            return Math.Sqrt(
                (p.xCood - this.xCood) * (p.xCood - this.xCood) +
                (p.yCood - this.yCood) * (p.yCood - this.yCood));
        }
        static void Main(string[] args)
        {
            //using Point method
            Point p1 = new Point(2, 3);
            Point p2 = new Point(3, 4);
            Console.WriteLine(p1.CalcDistance(p2));
            Point center = new Point();
            center.name = "Center of the coordinate system";
            Console.WriteLine("First point({0},{1} has name'{2}')",center.XCood,center.YCood,center.Name);

            Point point77 = new Point(7,7);
            Console.WriteLine("Second point({0},{1} has name'{2}')", point77.XCood, point77.YCood, point77.Name);
            Console.WriteLine();


            Person anonymos = new Person();
            Console.WriteLine("Person 1 name {0}, age {1}",anonymos.Name ??"[unnamed]",anonymos.Age);

            Person peter = new Person("Peter", 19);
            Console.WriteLine("Person 1 name {0}, age {1}", peter.Name, peter.Age);
            Console.WriteLine();

            AlarmClock defaultValue= new AlarmClock();
            Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock",defaultValue.Hours,defaultValue.Minutes);


            AlarmClock earlyAlarm = new AlarmClock(5,15);
            Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock", earlyAlarm.Hours, earlyAlarm.Minutes);
        }
    }
    public class Person
    {
        private string name;
        private int age;

        //constructor parameterless
        public Person()
        {
            this.name = null;
            this.age = 0;
        }
        //constructor w/h parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
    public class AlarmClock
    {
        private int hours = 9; // Inline initialization
        private int minutes = 0; // Inline initialization
        // Parameterless constructor (intentionally left empty)
        public AlarmClock()
        {
        }
        public AlarmClock(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }
    }
}
