using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolToNumber
{
    class SymbolToNumber
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length - 1; i++)
            {
                double sum = 0;
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    if (i % 2 == 0)
                    {
                        sum += (text[i] * secret + 1000) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum += (text[i] * secret + 1000) * 100;
                    }
                }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    if (i % 2 == 0)
                    {
                        sum += (text[i] * secret + 1000) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum += (text[i] * secret + 1000) * 100;
                    }
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    if (i % 2 == 0)
                    {
                        sum += (text[i] + secret + 500) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum += (text[i] + secret + 500) * 100;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        sum += (text[i] - secret) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum += (text[i] - secret) * 100;
                    }
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:f2}", sum);
                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
