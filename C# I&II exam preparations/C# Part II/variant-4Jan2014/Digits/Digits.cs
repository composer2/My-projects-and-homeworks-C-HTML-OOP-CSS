using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static int[,] digits;
        static List<bool[,]> ListOFPaterns()
        {
            var list = new List<bool[,]>();
            list.Add(new bool[,]
            {
                //faking zero
            });
            //one
            list.Add(new bool[,]
            {
                { false,false,true},
                { false,true,true},
                { true,false,true},
                { false,false,true},
                { false,false,true}
            });
            //two
            list.Add(new bool[,]
           {
                { false,true,false},
                { true,false,true},
                { false,false,true},
                { false,true,true},
                { true,true,true}
           });
            //three
            list.Add(new bool[,]
           {
                { true,true,true},
                { false,false,true},
                { true,true,true},
                { false,false,true},
                { true,true,true}
           });
            //four
            list.Add(new bool[,]
           {
                { true,false,true},
                { true,false,true},
                { true,true,true},
                { false,false,true},
                { false,false,true}
           });
            //five
            list.Add(new bool[,]
           {
                { true,true,true},
                { true,false,false},
                { true,true,true},
                { false,false,true},
                { true,true,true}
           });
            //six
            list.Add(new bool[,]
             {
                { true,true,true},
                { true,false,false},
                { true,true,true},
                { true,false,true},
                { true,true,true}
             });
            //seven
            list.Add(new bool[,]
           {
                { true,true,true},
                { false,false,true},
                { false,true,false},
                { false,true,false},
                { false,true,false}
           });
            //eight
            list.Add(new bool[,]
           {
                { true,true,true},
                { true,false,true},
                { false,true,false},
                { true,false,true},
                { true,true,true}
           });
            //nine
            list.Add(new bool[,]
           {
                { true,true,true},
                { true,false,true},
                { false,true,true},
                { false,false,true},
                 { true,true,true}
           });
            return list;
        }
        static bool CheckPatern(bool[,] pattern, int digit, int row, int col)
        {
            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    if (pattern[i, j])
                    {
                        if (digits[row + i, col + j] != digit)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var paterns = ListOFPaterns();
            digits = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] currLine = Console.ReadLine().Split();
                for (int col = 0; col < currLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currLine[col]);
                }
            }
            int sum = 0;
            for (int row = 0; row <= n - 5; row++)
            {
                for (int col = 0; col <= n - 3; col++)
                {
                    if (digits[row + 2, col] == 1)
                    {
                        if (CheckPatern(paterns[1], 1, row, col))
                        {
                            sum += 1;
                        continue;
                        }
                    }
                    if (digits[row+1,col]==2)
                    {
                        if (CheckPatern(paterns[2], 2, row, col))
                        {
                            sum += 2;
                        continue;
                        }
                    }
                    int currDigit = digits[row, col];
                    if (CheckPatern(paterns[currDigit],currDigit,row,col))
                    {
                        sum += currDigit;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
