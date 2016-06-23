using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            for (int s = 0; s < word.Length; s++)
            {
                Console.WriteLine(word[s]-'a');
            }
        }
    }
}
