using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum DayOfWeek
    {
        Mon, Tue, Wed, Thu, Fri, Sat, Sun
    }
    public class EnumExample
    {
        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Fri;
            Console.WriteLine(day);

            Console.WriteLine((int)day);
            day = DayOfWeek.Mon;
            Console.WriteLine(++day);

            day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Mon");
            Console.WriteLine(day);

            //Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            //Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

            //Console.WriteLine("The {0} coffee is {1} ml",normalCoffee.Size,(int)normalCoffee.Size);

            //Console.WriteLine("The {0} coffee is {1} ml", doubleCoffee.Size, (int)doubleCoffee.Size);

        }
    }
    public enum CoffeeSize
    {
        Small = 100,
        Normal = 150,
        Double = 300
    }
    public class Coffee
    {
        private CoffeeSize size;

        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }

        public CoffeeSize Size
        {
            get { return this.size; }
        }
    }
}
