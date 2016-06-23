using System;

namespace DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("true {0}",num);
            }
            else
            {
                Console.WriteLine("false {0}", num);
            }
        }
    }
}
