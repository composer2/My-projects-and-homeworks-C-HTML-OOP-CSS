using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int occurrences = 0;
            for (int i = 0; i <= text.Length-pattern.Length; i++)
            {
                if (text.Substring(i, pattern.Length)==pattern)
                {
                    occurrences++;
                }
            }
            Console.WriteLine(occurrences);
        }
    }
}
