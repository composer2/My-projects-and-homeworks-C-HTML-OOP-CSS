using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturingWithGrisko
{
    class FeaturingWithGrisko
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            //        DateTime start = DateTime.Now;
            var arr = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i];
            }
            Array.Sort(arr);
            long count = 0;
            if (IsUniquePermutation(arr))//check if the input is unique
            {
                count++;
            }
            while (NextPermutation(arr))//generate next permutation
            {
                if (IsUniquePermutation(arr))//check if is unique
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            //          DateTime end = DateTime.Now;
            //Console.WriteLine(end-start);
        }
        private static bool NextPermutation(int[] numList)
        {
            /*
             Knuths
             1. Find the largest index j such that a[j] < a[j + 1]. If no such index exists, the permutation is the last permutation.
             2. Find the largest index l such that a[j] < a[l]. Since j + 1 is such an index, l is well defined and satisfies j < l.
             3. Swap a[j] with a[l].
             4. Reverse the sequence from a[j + 1] up to and including the final element a[n].

             */
            var largestIndex = -1;
            for (var i = numList.Length - 2; i >= 0; i--)
            {
                if (numList[i] < numList[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }

            if (largestIndex < 0) return false;

            var largestIndex2 = -1;
            for (var i = numList.Length - 1; i >= 0; i--)
            {
                if (numList[largestIndex] < numList[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }

            var tmp = numList[largestIndex];
            numList[largestIndex] = numList[largestIndex2];
            numList[largestIndex2] = tmp;

            for (int i = largestIndex + 1, j = numList.Length - 1; i < j; i++, j--)
            {
                tmp = numList[i];
                numList[i] = numList[j];
                numList[j] = tmp;
            }

            return true;
        }
        static bool IsUniquePermutation(int[] permutation)
        {
            int previous = permutation[0];
            for (int i = 1; i < permutation.Length; i++)
            {
                if (previous == permutation[i])
                {
                    return false;
                }
                previous = permutation[i];
            }
            return true;
        }
    }
}