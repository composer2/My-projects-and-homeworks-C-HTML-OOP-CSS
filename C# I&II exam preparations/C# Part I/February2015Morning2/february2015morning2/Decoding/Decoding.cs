using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length - 1; i++)
            {
                double sum = 0.0;
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    if (i % 2 == 0)
                    {
                        sum= ((text[i] * salt) + 1000) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum = ((text[i] * salt) + 1000) * 100.0;
                    }
                }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    if (i % 2 == 0)
                    {
                        sum = ((text[i] * salt) + 1000) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum = ((text[i] * salt) + 1000) * 100.0;
                    }
                }
                else if (text[i] >= '0' && text[i] <= '9')
                { 
                    if (i % 2 == 0)
                    {
                        sum = (text[i] + salt + 500) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum = (text[i] + salt + 500) * 100.0;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        sum = (text[i] - salt) / 100.0;
                    }
                    else if (i % 2 == 1)
                    {
                        sum = (text[i] - salt) * 100.0;
                    }
                }
                if (i%2==0)
                {
                    Console.WriteLine("{0:f2}",sum);
                }
                else
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
