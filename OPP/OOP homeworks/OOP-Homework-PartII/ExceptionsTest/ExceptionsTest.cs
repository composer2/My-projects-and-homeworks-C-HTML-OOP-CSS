namespace ExceptionsTest
{
    using System;
    using System.Globalization;

    class ExceptionsTest
    {
        static void Main(string[] args)
        {
            //number test
            Console.WriteLine("Enter number: ");
            var num = decimal.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                throw new InvalidRangeException<decimal>("Number must be 1-100", 1, 100);
            }
            Console.WriteLine(new string('*', 40));
            //datetime test
            //date in format dd.MM.yyyy
            Console.WriteLine("Enter date in format dd.MM.yyyy");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            var startPoint = new DateTime(1984, 08, 03);
            var endPoint = new DateTime(2016, 08, 03);

            if (date<startPoint||date>endPoint)
            {
                throw new InvalidRangeException<DateTime>("Date must be between 03.08.1984 and 03.08.2016.", startPoint, endPoint);
            }
            Console.WriteLine("Test passed without exceptions");
        }
    }
}
