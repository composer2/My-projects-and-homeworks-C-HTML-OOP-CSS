using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassesAndStruct
{
   public static class IEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            //data validation
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }
            //sum
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            //validate
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }

            //product
            dynamic product = 1;
            foreach (var item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }
            T min = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(min) <= 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }
            T max = collection.First();
            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty");
            }
            dynamic sum = default(T);
            decimal count = 0M;

            foreach (var item in collection)
            {
                sum += item;
                count++;
            }
            var average = sum / count;
            return average;
        }
    }
}
