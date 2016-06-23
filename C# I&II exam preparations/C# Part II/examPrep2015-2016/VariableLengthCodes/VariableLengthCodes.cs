using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLengthCodes
{
    class VariableLengthCodes
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var binary = new StringBuilder();

            foreach (var num in numbers)
            {
                binary.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
            }

            int n = int.Parse(Console.ReadLine());
            var dictionary = new char[n+1];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var symbol = line[0];
                int index = int.Parse(line.Substring(1));
                dictionary[index] = symbol;
            }

            var result = new StringBuilder();
            var ones = binary.ToString().Split('0');

            foreach (var size in ones)
            {
                result.Append(dictionary[size.Length]);
            }
            
            Console.WriteLine(result.ToString());
        }
    }
}
