using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianRugs
{
    class PersianRugs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;

            int change2 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', i) + "\\");
                if ((d * 2 + 5) == n * 2 - 1 - change2)
                {
                    Console.Write(new string(' ', d) + "\\.../" + new string(' ', d));
                }
                else if ((d * 2 + 3) == n * 2 - 1 - change2)
                {
                    Console.Write(new string(' ', d) + "\\./" + new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 1 - change2));
                }

                Console.WriteLine("/" + new string('#', i));
                change2 += 2;
            }
            //2nd part
            Console.WriteLine(new string('#', n) + "X" + new string('#', n));
            //3rd part
            change2 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', n - 1 - i) + "/");

                if ((d * 2 + 5) == 1 + change2)
                {
                    Console.Write(new string(' ', d) + "/...\\" + new string(' ', d));
                }
                else if ((d * 2 + 3) == 1 + change2)
                {
                    Console.Write(new string(' ', d) + "/.\\" + new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', 1 + change2));
                }

                Console.WriteLine("\\" + new string('#', n - 1 - i));
                change2 += 2;

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('#', i));
                Console.Write("\\");
                int space = width - i - i - 1 - 1 - d - d;
                if (space > 1)
                {
                    Console.Write(new string(' ', d));
                    Console.Write("\\");
                    Console.Write(new string('.', space - 2));
                    Console.Write("/");
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - i - i - 1 - 1));
                }
                Console.Write("/");
                Console.WriteLine(new string('#', i));

            }
            //2nd part
            Console.WriteLine(new string('#', n) + "X" + new string('#', n));
            //3rd part
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(new string('#', i));
                Console.Write("/");
                int space = width - i - i - 1 - 1 - d - d;
                if (space > 1)
                {
                    Console.Write(new string(' ', d));
                    Console.Write("/");
                    Console.Write(new string('.', space - 2));
                    Console.Write("\\");
                    Console.Write(new string(' ', d));
                }
                else
                {
                    Console.Write(new string(' ', width - i - i - 1 - 1));
                }
                Console.Write("\\");
                Console.WriteLine(new string('#', i));
            }
        }
    }
}
