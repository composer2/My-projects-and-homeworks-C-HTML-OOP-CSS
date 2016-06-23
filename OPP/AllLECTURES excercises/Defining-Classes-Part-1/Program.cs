using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_1
{
    class Program
    {
        public const double Pi = 3.141517;
        public readonly double Size;

        public Program(int size)
        {
            this.Size = size;
        }

        static void Main(string[] args)
        {
            //class Dog
            var dog = new Dog("Sharo", "Koferman");
            var dog2 = new Dog();
            var allDogs = new Dog[] { dog, dog2 };
            foreach (var doge in allDogs)
            {
                doge.SayBay();
            }

            //rectabgle and User profile
            Rectangle first = new Rectangle(5.0f, 6.0f);
            Console.WriteLine("Rectangle {0}x{1} has area {2}", first.Width, first.Height, first.Area);
            Console.WriteLine(first);//doesnt have to string
            Console.WriteLine();
            UserProfile profile = new UserProfile(12345, "Bob", "Dylan");
            Console.WriteLine(profile);//has to string method

            // person points alarm clock
            var anonimys = new Person();
            Console.WriteLine("Person name: {0}, age: {1}", anonimys.Name ?? "no name", anonimys.Age);
            var peter = new Person("Pesho", 18);
            Console.WriteLine("Person name: {0}, age: {1}", peter.Name ?? "no name", peter.Age);
            Console.WriteLine();
            var defAlarm = new AlarmClock();
            Console.WriteLine("Wake up its {0:d2}:{1:d2} o'clock.", defAlarm.Hours, defAlarm.Minutes);
            var Alarm = new AlarmClock(12, 59);
            Console.WriteLine("Wake up its {0:d2}:{1:d2} o'clock.", Alarm.Hours, Alarm.Minutes);
            var centerPoint = new Point();
            centerPoint.Name = "This is center of coordinate system";
            Console.WriteLine("fisrt point {0}x{1} has name {2}", centerPoint.X, centerPoint.Y, centerPoint.Name);
            var center = new Point(5, 5);
            Console.WriteLine("fisrt point {0}x{1} has name {2}", center.X, center.Y, center.Name);
            Console.WriteLine("Distance between p1 and p2: {0}",centerPoint.CalcDistance(center));
            Console.WriteLine();

            //constant from program.cs
            Console.WriteLine(Program.Pi);
            var c = new Program(5);
            Console.WriteLine(c.Size);

            //enum coffe size
            Coffee smallCoffe = new Coffee(CoffeeSize.small);
            Coffee medCoffe = new Coffee(CoffeeSize.medium);
            Coffee largeCoffe = new Coffee(CoffeeSize.large);
            Console.WriteLine("The {0} is {1}ml big", smallCoffe.size, (int)smallCoffe.size);
            Console.WriteLine("The {0} is {1}ml big", medCoffe.size, (int)medCoffe.size);
            Console.WriteLine("The {0} is {1}ml big", largeCoffe.size, (int)largeCoffe.size);

            //enum example day of week
            var day = DayOfWeek.wen;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            day = DayOfWeek.fri;
            Console.WriteLine(++day);
            var day2 = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "mon");
            Console.WriteLine(day2);

            // obj state person2 protect the obs state demo
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            var p2 = new Person2(name, age);
            Console.WriteLine("Hello {0}", p2.Name);
            Console.WriteLine("Your age is: {0}", p2.Age);

        }
    }
}
