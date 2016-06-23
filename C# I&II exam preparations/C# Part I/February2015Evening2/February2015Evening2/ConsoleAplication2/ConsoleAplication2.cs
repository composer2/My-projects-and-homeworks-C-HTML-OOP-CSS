using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication2
{
    class ConsoleAplication2
    {
        static void Main(string[] args)
        {
            string num = (Console.ReadLine());
            BigInteger product1 = 1;
            BigInteger product2 = 1;
            int numCount = 1;
            int evenPos = 0;
            while (num != "END")
            {
                BigInteger sum = 1;
                if (numCount<=10&&evenPos%2==0)
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i]!='0')
                        {
                            sum *= num[i]-'0';
                        }
                    }
                    if (sum!=0)
                    {
                        product1 *= sum;
                    }
                }
                if (numCount > 10 && evenPos % 2 == 0)
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i] != '0')
                        {
                            sum *= num[i]-'0';
                        }
                    }
                    if (sum != 0)
                    {
                        product2 *= sum;
                    }
                }
                numCount++;
                evenPos++;
                num = Console.ReadLine();
            }
            if (numCount==1)
            {
                BigInteger product3 = 1;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] != '0')
                    {
                        product3 *= num[i]-'0';
                    }
                }
                Console.WriteLine(product3);
            }
            else if(numCount>1&&evenPos<=10)
            {
                Console.WriteLine(product1);
            }
            else if (numCount > 1 && evenPos > 10)
            {
                Console.WriteLine(product1);
                Console.WriteLine(product2);
            }
        }
    }
}
