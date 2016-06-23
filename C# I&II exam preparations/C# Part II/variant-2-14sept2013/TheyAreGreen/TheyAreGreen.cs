using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheyAreGreen
{
    class TheyAreGreen
    {
        static bool NextPermutation(int[] numbers)
        {
            var largestIndex = -1;
            for (var i = numbers.Length - 2; i >= 0; i--)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }
            if (largestIndex < 0)
            {
                return false;
            }
            var largestIndex2 = -1;
            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[largestIndex] < numbers[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }
            var tmp = numbers[largestIndex];
            numbers[largestIndex] = numbers[largestIndex2];
            numbers[largestIndex2] = tmp;

            for (int i = largestIndex + 1, j = numbers.Length - 1; i < j; i++, j--)
            {
                tmp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = tmp;
            }
            return true;

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          //  DateTime start = DateTime.Now;

            int[] letters = new int[n];

            for (int i = 0; i < n; i++)
            {
                letters[i] = (int)(char.Parse(Console.ReadLine()));
            }
            Array.Sort(letters);
            int counter = 0;

            if (IsMatch(letters))
            {
                counter = 1;
            }

            while (NextPermutation(letters))
            {
                if (IsMatch(letters))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
           // DateTime end = DateTime.Now;

            //Console.WriteLine(end - start);

        }

        public static bool IsMatch(int[] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if ((char)word[i] == (char)word[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
