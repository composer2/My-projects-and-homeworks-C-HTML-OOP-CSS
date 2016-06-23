using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='@')
                {
                    continue;
                }
                else if(text[i]>='0'&&text[i]<='9')
                {
                    result *= text[i] - 48;
                }
                else if (text[i]>='A'&&text[i]<='Z')
                {
                    result += text[i] - 65;
                }
                else if (text[i]>='a'&&text[i]<='z')
                {
                    result += text[i] - 97;
                }
                else
                {
                    result %= m;
                }
            }
                Console.WriteLine(result);
        }
    }
}
