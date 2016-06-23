using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class RelevanceIndex
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var wordRepeats = new List<int>();
            var linesToPrint = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var lines = Console.ReadLine().Split(new string[] { ",", ".", "(", ")", ";", "-", "!", "?"," " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currLine = new StringBuilder();
                var occurancies = 0;
                for (int j = 0; j < lines.Length; j++)
                {
                    
                    if (lines[j].ToLower()==keyWord.ToLower())
                    {
                        occurancies++;
                        currLine.Append(lines[j].ToUpper()+" ");
                    }
                    else
                    {
                        currLine.Append(lines[j]+" ");
                    }
                }
                linesToPrint.Add(currLine.ToString().TrimEnd());
                wordRepeats.Add(occurancies);
            }
            var sorted = new List<string>();

            while (sorted.Count<linesToPrint.Count)
            {
                int biggestNumber = 0;
                int maxLinesToprintIndex = 0;
                for (int i = 0; i < wordRepeats.Count; i++)
                {
                    if (biggestNumber < wordRepeats[i])
                    {
                        biggestNumber = wordRepeats[i];
                        maxLinesToprintIndex = i;
                    }
                }
                sorted.Add(linesToPrint[maxLinesToprintIndex]);
                wordRepeats[maxLinesToprintIndex] = -1;
            }
            Console.WriteLine(string.Join(Environment.NewLine,sorted));
        }
    }
}
