using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class MovingLetters
    {
        static StringBuilder ExtractLetter(string[] words)
        {
            StringBuilder resultCombo = new StringBuilder();

            int maxWordLenght = 0;


            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                if (maxWordLenght < currWord.Length)
                {
                    maxWordLenght = currWord.Length;
                }
            }
            for (int i = 0; i < maxWordLenght; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currWord = words[j];
                    if (currWord.Length >= i)
                    {
                        int lastLetter = currWord.Length - 1 - i;
                        resultCombo.Append(currWord[lastLetter]);
                    }
                }
            }
            return resultCombo;
        }
        static string MoveLetters(StringBuilder strangeWords)
        {
            for (int i = 0; i < strangeWords.Length; i++)
            {
                char currSymbol = strangeWords[i];
                int transition = char.ToLower(currSymbol)-'a'+1;
                strangeWords.Remove(i, 1);
                int nextPosition = (i + transition) % strangeWords.Length+1;
                strangeWords.Insert(nextPosition, currSymbol);
            }  
            return strangeWords.ToString();
        }
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries ).ToArray();

            StringBuilder resultCombo = ExtractLetter(words);
            string finalResult = MoveLetters(resultCombo);

            Console.WriteLine(finalResult);
        }
    }
}
