using System;
namespace BinaryShort
{
    class BinaryShort
    {
        static string BinShort(short number)
        {
            string binary = "";
            for (int i = 0; i < 16; i++)
            {
                binary = (number >> i & 1) + binary;
            }
            return binary;
        }
        static void Main()
        {
            short input = short.Parse(Console.ReadLine());
            Console.WriteLine(BinShort(input));
        }
    }
}
