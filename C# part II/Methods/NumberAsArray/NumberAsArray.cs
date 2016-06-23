using System;
using System.Collections.Generic;
using System.Linq;
namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main(string[] args)
        {
            var arrLenghts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numList1 = FillList(arrLenghts[0]);
            var numList2 = FillList(arrLenghts[0]);

            var result = SumOfList(numList1, numList2);
            Console.WriteLine(string.Join(" ", result));
        }
        static List<int> FillList(int n)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static List<int> SumOfList(List<int> list1, List<int> list2)
        {
            var result = new List<int>();
            var bigger = new List<int>();
            var smaller = new List<int>(); ;
            if (list1.Count >= list2.Count)
            {
                bigger = list1;
                smaller = list2;
            }
            else
            {
                bigger = list2;
                smaller = list1;
            }
            for (int i = 0; i < bigger.Count; i++)
            {
                result.Add(bigger[i]);
            }
            for (int i = 0; i < smaller.Count; i++)
            {
                result[i] += smaller[i];
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] >= 10)
                {
                    result[i] = result[i] % 10;
                    result[i + 1]++;
                }
                if (result[i] >= 10 && result[i] == result.Count - 1)
                {
                    result.Add(1);
                }
            }
            return result;
        }
    }
}
