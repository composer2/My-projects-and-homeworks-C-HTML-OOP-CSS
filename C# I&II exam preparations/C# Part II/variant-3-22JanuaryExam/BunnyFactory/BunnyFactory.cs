using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class BunnyFactory
    {
        static void Main(string[] args)
        {
            var cages = Input();
            for (int stepNum = 1; ; stepNum++)
            {
                if (cages.Count < stepNum)
                {
                    break;
                }

                var cagesCount = (int)SumListValuesInRange(cages, 0, stepNum - 1);
                if (cages.Count < stepNum + cagesCount)
                {
                    break;
                }
                var sum = SumListValuesInRange(cages, stepNum, cagesCount + stepNum - 1);
                var product = ProductListValuesInRange(cages, stepNum, cagesCount + stepNum - 1);
                string result = sum.ToString() + product.ToString();
                for (int i = cagesCount+stepNum; i < cages.Count; i++)
                {
                    result += cages[i];
                }
                var newCages = new List<int>();
                foreach (var ch in result)
                {
                    if (ch!='0'&&ch!='1')
                    {
                        newCages.Add(ch - '0');
                    }
                }
                cages = newCages;
            }
            Console.WriteLine(string.Join(" ",cages));
        }
        static BigInteger ProductListValuesInRange(List<int> list, int start ,int end)
        {
            BigInteger product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= list[i];
            }
            return product;
        }
        static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)
        {
            BigInteger sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        static List<int> Input()
        {
            var cages = new List<int>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var cage = int.Parse(line);
                cages.Add(cage);
            }
            return cages;
        }
    }
}
