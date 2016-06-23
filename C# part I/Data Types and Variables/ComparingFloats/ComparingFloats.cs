using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var eps = 0.000001;
            
            if (a > b)
            {
                if (a - b <= eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else if(b>a)
            {
                if (b - a <= eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
