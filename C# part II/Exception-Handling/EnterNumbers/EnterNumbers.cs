using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            try
            {
                var result = new int[12];
                for (int i = 1; i < 11; i++)
                {
                    result[i] = int.Parse(Console.ReadLine());
                }
                result[0] = 1;
                result[11] = 100;
                bool IsValidSequence = true;
                for (int i = 1; i < result.Length - 1; i++)
                {
                    if (result[i] <= result[0] || result[i] >= result[11])
                    {
                        IsValidSequence = false;
                        break;
                    }

                    if (result[i] >= result[i + 1])
                    {
                        IsValidSequence = false;
                        break;
                    }
                }
                if (IsValidSequence)
                {
                    Console.WriteLine(string.Join(" < ", result));
                }
                else
                {
                    Console.WriteLine("Exception");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
