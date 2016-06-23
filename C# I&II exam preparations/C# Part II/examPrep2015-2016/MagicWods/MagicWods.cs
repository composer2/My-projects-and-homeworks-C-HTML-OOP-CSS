using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sentenceOfWords = new List<string>();
            var longestWord = 0;
            var result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                sentenceOfWords.Add(input);
                if (input.Length > longestWord)
                {
                    longestWord = input.Length;
                }
            }

            for (int j = 0; j < sentenceOfWords.Count; j++)
            {
                var word = sentenceOfWords[j];
                var newPositionOfWord = word.Length % (n + 1);
                sentenceOfWords[j] = "";
                sentenceOfWords.Insert(newPositionOfWord, word);
                sentenceOfWords.RemoveAll(String.IsNullOrEmpty);
            }
            for (int i = 0; i < longestWord; i++)
            {
                foreach (var word in sentenceOfWords)
                {

                    if (i < word.Length)
                    {
                        result.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}