using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class RelevanceIndex
    {
        static string[] symbols = new string[] { ",", ".", "(", ")", ";", "-", "!", "?"," " };

        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            int numberOfParagraphs = int.Parse(Console.ReadLine());

            List<string> paragraphs = new List<string>();
            List<int> indexes = new List<int>();
            for (int i = 0; i < numberOfParagraphs; i++)
            {
                var currLine = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                int occurancies = 0;
                for (int j = 0; j < currLine.Length; j++)
                {
                    string word = currLine[j];
                    if (word.ToLower()==searchWord.ToLower())
                    {
                        occurancies++;
                        currLine[j] = word.ToUpper();
                    }
                }
                paragraphs.Add(string.Join(" ", currLine));
                indexes.Add(occurancies);
            }
            List<string> SortedParagraphs = new List<string>();
            while (SortedParagraphs.Count< paragraphs.Count)
            {
                int maxIndex = 0;
                int maxParagraphIndex = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (maxIndex < indexes[i])
                    {
                        maxIndex = indexes[i];
                        maxParagraphIndex = i;
                    }
                }
                SortedParagraphs.Add(paragraphs[maxParagraphIndex]);
                indexes[maxParagraphIndex] = -1;
            }
            Console.WriteLine(string.Join(Environment.NewLine,SortedParagraphs));
        }
    }
}
