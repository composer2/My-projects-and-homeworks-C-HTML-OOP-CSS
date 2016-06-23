using System;
using System.Globalization;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(input, "MM.dd.yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Now;

            TimeSpan age = today - birthday;
            var ageInDays = age.TotalDays / 365.25;

            if (ageInDays<1)
            {
                var notAleapYear = age.TotalDays / 365;
                Console.WriteLine((int)notAleapYear);
                Console.WriteLine((int)notAleapYear + 10);
            }
            else
            {
                Console.WriteLine((int)ageInDays);
                Console.WriteLine((int)ageInDays+10);
            }
        }
    }
}
