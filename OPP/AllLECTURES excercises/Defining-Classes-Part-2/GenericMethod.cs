using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_2
{
    internal class GenericMethod
    {
        public static T Min<T>(T first, T second)
         where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
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
    }
}
