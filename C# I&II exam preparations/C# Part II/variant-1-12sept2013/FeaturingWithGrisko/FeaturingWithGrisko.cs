using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturingWithGrisko
{
    class FeaturingWithGrisko
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputToCharArray = input.ToCharArray();
            Array.Sort(inputToCharArray);
            int count = 0;
            do
            {
                if (IsMatch(inputToCharArray))
                {
                    count++; 
                }
            } while (NextPermutation(inputToCharArray));
            Console.WriteLine(count);
        }
        public static bool NextPermutation(char [] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index]<array[index+1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index]>=array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }
            return false;
        }

        public static bool IsMatch(char[] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i]==word[i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
