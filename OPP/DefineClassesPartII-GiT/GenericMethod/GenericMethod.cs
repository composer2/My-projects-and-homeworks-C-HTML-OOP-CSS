using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class GenericMethod
    {
        public static T Min<T>(T first, T second)
        where T : IComparable<T>
        {
            if (first.CompareTo(second)<=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            int i = 5;
            int j = 7;
            int min = Min<int>(i, j);
            Console.WriteLine("Min({0},{1}) = {2}",i,j,min);

            string first = "Rakiya";
            string second = "Beer";
            string minString = Min<string>(first, second);
            Console.WriteLine("Min({0},{1}) = {2}",first,second, minString);

            //Point p1 = new Point();
            //Point p2 = new Point();
            //Point minPoint = Min(p1, p2); // This will not compile

        }
    }
}
