using System;


namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            num = num / 100;
            if (num % 10 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}",num%10);
            }
        }
    }
}
