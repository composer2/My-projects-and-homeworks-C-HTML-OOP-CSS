using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLenghtCoding
{
    class VariableLenghtCoding
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var numbersAsString = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder encoded = new StringBuilder();
            foreach (var str in numbersAsString)
            {
                var num = int.Parse(str);
                encoded.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
            }
            int n = int.Parse(Console.ReadLine());
            char[] dictionary = new char[n + 1];
            for (int i = 0; i < n; i++)
            {
                var text = Console.ReadLine();
                char symbol = line[0];
                int index = int.Parse(text.Substring(1));
                dictionary[index] = symbol;
            }
            StringBuilder decoded = new StringBuilder();
            int ones = 0;
            foreach (var ch in encoded.ToString())
            {
                if (ch == '1')
                {
                    ones++;
                }
                else
                {
                    decoded.Append(dictionary[ones]);
                    ones = 0;
                }
            }
            if (ones > 0)
            {
                decoded.Append(dictionary[ones]);

            }
            Console.WriteLine(decoded);
        }
    }
}
