using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerationInitiliaziation
{
    public class Coffee
    {
        public enum CoffeeSize
        {
            Small = 100, Normal = 150, Double = 300, Overwhelming = 600
        }

        private CoffeeSize size;

        private Coffee(CoffeeSize size)
        {
            this.size = size;
        }

        public CoffeeSize Size
        {
            get { return this.size; }
        }


        public double CalcPrice(Coffee.CoffeeSize coffeSize)
        {
            switch (coffeSize)
            {
                case CoffeeSize.Small: return 0.20;
                case CoffeeSize.Normal: return 0.30;
                case CoffeeSize.Double: return 0.60;
                case CoffeeSize.Overwhelming: return 1.20;
                default: throw new InvalidOperationException("Unsupported coffee quantity: " + (int)coffeSize);
            }
        }

        static void Main(string[] args)
        {
            Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

            Console.WriteLine("The {0} coffee is {1} ml.", normalCoffee.Size, (int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.", doubleCoffee.Size, (int)doubleCoffee.Size);
            Console.WriteLine("{0:f2}lv",normalCoffee.CalcPrice(normalCoffee.Size));
        }
    }
}
