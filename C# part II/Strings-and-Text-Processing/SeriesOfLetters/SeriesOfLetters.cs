using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            //var result = new StringBuilder();
            //result.Append(encoded[0]);
            //for (int i = 0; i < encoded.Length - 1; i++)
            //{

            //    if (encoded[i] != encoded[i + 1])
            //    {
            //        result.Append(encoded[i + 1]);
            //    }
            //}
            //Console.WriteLine(result.ToString());

            var encoded = Console.ReadLine();

            var result = new StringBuilder();
            char previousSymbol = encoded[0];
            for (int i = 0; i < encoded.Length; i++)
            {
                if (encoded[i] == previousSymbol)
                {
                    continue;
                }
                else
                {
                    result.Append(previousSymbol);
                }
                previousSymbol = encoded[i];
            }
            result.Append(previousSymbol);
            Console.WriteLine(result.ToString());
        }
    }
}
