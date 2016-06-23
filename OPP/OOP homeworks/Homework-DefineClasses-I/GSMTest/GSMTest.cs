using AllClasses;
using System;
namespace GSMTest
{
    public class GSMTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mobile Phone test");
            Console.WriteLine(new string('*', 40));
            //creates array with GSM instances
            var multipleGSMs = new GSM[]
            {
            new GSM("Lenovo 8","Lenovo"),
            new GSM("Xperia", "Nokia", 590),
            new GSM("Iphone7", "Apple", 1590, "Boncho"),
            new GSM("Iphone5", "Apple", new Battery("6800 mAh")),
            new GSM("Iphone6", "Apple", new Battery("5800 mAh",400)),
            new GSM("Samsung S6", "Samsung", new Battery("5800 mAh",300,48)),
            new GSM("Samsung S5", "Samsung", new Battery("4800 mAh",200,28,Battery.Type.LiIon)),
            new GSM("Samsung S7", "Samsung", new Display(1440,420)),
            new GSM("Samsung S2", "Samsung", new Display(440,220,160000)),
            new GSM("One M9", "HTC", 500, new Battery("Non-removable 2840 mAh", 391, 25), new Display(1080, 1920, 160000000))
            };

            //displays the information about the GSMs in the array
            foreach (var gsm in multipleGSMs)
            {
                Console.WriteLine(gsm.ToString());
            }

            //displays the information about the static property IPhone7
            Console.WriteLine("Information about iPhone 7: ");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(GSM.IPhone7);

            //tests calls
            GSMCallHistoryTest.CallHistoryTest();
        }
    }
}