using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();
            string[] cardColor = { " of spades, ", " of clubs, ", " of hearts, ", " of diamonds" };
            int n = 0;
            switch (card)
            {
                case "2": n = 2; break;
                case "3": n = 3; break;
                case "4": n=4; break;
                case "5": n=5; break;
                case "6": n=6; break;
                case "7": n=7; break;
                case "8": n=8; break;
                case "9": n=9; break;
                case "10": n=10; break;
                case "J": n=11; break;
                case "Q": n=12; break;
                case "K": n=13; break;
                case "A": n=14; break;
                default: break;
            }
            for (int i = 2; i <=n; i++)
            {
                foreach (var color in cardColor)
                {
                    if (i==14)
                    {
                        Console.Write("A"+color);
                    }
                    else if (i==13)
                    {
                        Console.Write("K"+color);
                    }
                    else if (i==12)
                    {
                        Console.Write("Q"+color);
                    }
                    else if (i==11)
                    {
                        Console.Write("J"+color);
                    }
                    else
                    {
                    Console.Write(i+color);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
