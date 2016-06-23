using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {

            ulong n = int.Parse(Console.ReadLine());
            ulong firstNum = 0;
            ulong secondNum = 1;
            ulong thirdNum = 0;
            
            

                if (n == 1)
                {
                    Console.WriteLine(firstNum);
                }
                else if (n == 2)
                {
                    Console.WriteLine("{0}, {1}", firstNum, secondNum);
                }
                else if (n > 2)
                {
                    Console.Write("{0}, {1}, ", firstNum, secondNum);
                    for (int i = 1; i <= n - 2; i++)
                    {
                        thirdNum = firstNum + secondNum;
                        firstNum = secondNum;
                        secondNum = thirdNum;
                        if (n - 2 == i)
                        {
                            Console.WriteLine(thirdNum);
                        }
                        else
                        {
                            Console.Write(thirdNum + ", ");
                        }
                    }
                }
            }
        }
    }

