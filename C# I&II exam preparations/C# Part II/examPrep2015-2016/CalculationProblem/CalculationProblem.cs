using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProblem
{
    class CalculationProblem
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split();
            long result = 0L;

            foreach (var word in text)
            {
                long tmpResult = 0L;
                for (int i = 0; i < word.Length; i++)
                {
                    tmpResult *= 23;
                    tmpResult += word[i] - 'a';
                }
                result += tmpResult;
            }

            var sumResultIn23th = "";
            var tmp2Result = result;

            while (tmp2Result>0)
            {
                char symobl =(char)((tmp2Result % 23)+'a');
                sumResultIn23th = symobl + sumResultIn23th;
                tmp2Result /= 23;
            }
            Console.WriteLine("{0} = {1}",sumResultIn23th.ToString(),result);
        }
    }
}
