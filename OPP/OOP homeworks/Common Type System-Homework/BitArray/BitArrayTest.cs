namespace BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArrayTest
    {
        static void Main(string[] args)
        {
            //creating arrays
            BitArray first = new BitArray(12345678987654);
            BitArray second = new BitArray(2345678567856);

            //printing and comparing arrays
            Console.WriteLine("First array: ");
            Console.WriteLine(new string('*', 40));
            PrintArray(first);
            Console.WriteLine("Value at index 5 is: {0}", first[5]);
            Console.WriteLine("Hash Code: {0}", first.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("Second array: ");
            Console.WriteLine(new string('*', 40));
            PrintArray(second);
            Console.WriteLine("Value at index 9 is: {0}", second[9]);
            Console.WriteLine("Hash Code: {0}", second.GetHashCode());

            var areEqual = first == second;
            Console.WriteLine();
            Console.WriteLine("First Array  == Second Array? {0}", areEqual);
        }
        private static void PrintArray(BitArray arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
