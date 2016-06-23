using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine(n * 10); break;
                case 2: Console.WriteLine(n * 10); break;
                case 3: Console.WriteLine(n * 10); break;
                case 4: Console.WriteLine(n * 100); break;
                case 5: Console.WriteLine(n * 100); break;
                case 6: Console.WriteLine(n * 100); break;
                case 7: Console.WriteLine(n * 1000); break;
                case 8: Console.WriteLine(n * 1000); break;
                case 9: Console.WriteLine(n * 1000); break;
                default: Console.WriteLine("invalid score"); break;
            }
        }
    }
}
