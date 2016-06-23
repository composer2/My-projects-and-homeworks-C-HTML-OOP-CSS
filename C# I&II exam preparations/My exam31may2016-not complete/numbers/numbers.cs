using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class numbers
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine().ToLower();
            var operation = Console.ReadLine();
            var secondNumber = Console.ReadLine().ToLower();

            var digits = new List<string> { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

            BigInteger firstNumberIn10th = 0;
            BigInteger secondNumberIn10th = 0;

            for (int i = 0; i < firstNumber.Length; i += 3)
            {
                var digitIn10th = firstNumber.Substring(i, 3);
                var indexOfDigitIn10th = digits.IndexOf(digitIn10th);
                firstNumberIn10th *= 10;
                firstNumberIn10th += indexOfDigitIn10th;
            }

            for (int i = 0; i < secondNumber.Length; i += 3)
            {
                var digitIn10th = secondNumber.Substring(i, 3);
                var indexOfDigitIn10th = digits.IndexOf(digitIn10th);
                secondNumberIn10th *= 10;
                secondNumberIn10th += indexOfDigitIn10th;
            }
            BigInteger result = 0;
            if (operation == "-")
            {
                result = firstNumberIn10th - secondNumberIn10th;
            }
            else if (operation == "+")
            {
                result = firstNumberIn10th + secondNumberIn10th;
            }

            if (result == 0)
            {
                Console.WriteLine(digits[0]);
                return;
            }

            var finalResult = "";
            do
            {
                var currDigit = (int)(result % 10);
                finalResult = digits[currDigit] + finalResult;
                result /= 10;
            } while (result > 0);

            Console.WriteLine(finalResult);
        }
    }
}

