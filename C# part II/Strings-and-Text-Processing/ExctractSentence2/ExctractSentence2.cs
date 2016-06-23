using System;
using System.Collections.Generic;
using System.Text;

namespace ExctractSentence2
{
    class ExctractSentence2
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine();
            var original = text.Split('.');
            var result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    result.Append(".");
                }
                else if (char.IsLetter(text[i]))
                {
                    result.Append(text[i]);
                }
                else
                {
                    result.Append(" ");
                }
            }
            var answer = result.ToString().ToLower().Split('.');
            for (int j = 0; j < answer.Length; j++)
            {
                var tmpAnswer = answer[j].Split();
                for (int i = 0; i < tmpAnswer.Length; i++)
                {
                    if (tmpAnswer[i] == keyWord.ToLower())
                    {
                        Console.Write(original[j] + ".");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
