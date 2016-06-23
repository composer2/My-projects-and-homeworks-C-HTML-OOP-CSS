using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string brackets = Console.ReadLine();
            int leftBracketCount = 0;
            int rightBracketCount = 0;

            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i]=='(')
                {
                    leftBracketCount++;
                }
                if (brackets[i]==')')
                {
                    rightBracketCount++;
                }
            }
            Console.WriteLine(leftBracketCount==rightBracketCount? "Correct": "Incorrect");
        }
    }
}
