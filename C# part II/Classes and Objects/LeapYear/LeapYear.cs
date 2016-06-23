using System;
namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int leap = int.Parse(Console.ReadLine());
            DateTime.IsLeapYear(leap);
            if (DateTime.IsLeapYear(leap))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
