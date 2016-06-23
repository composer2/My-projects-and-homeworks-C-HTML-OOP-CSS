using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClasses
{
    public class GSMCallHistoryTest
    {
        //method for testing the calls
        public static void CallHistoryTest()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Phone calls test");

            //GSM instance from the GSM class
            var phone = new GSM("Lada Niva", "Russia");

            //add calls
            phone.AddCall(new Call("0898-12-12-12", 300));
            phone.AddCall(new Call("0888-72-72-72", 100));
            phone.AddCall(new Call("0878-32-32-32", 200));
            phone.AddCall(new Call("0877-22-22-22", 400));
            //info about the calls
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Calls added");
            Console.WriteLine("Calls: ");
            foreach (var call in phone.CallHistory)
            {
                Console.WriteLine(call.ToString());
                Console.WriteLine();
            }

            //total price at 0.37 per/minute
            Console.WriteLine(new string('*', 40));
            var price = phone.CallPrice(0.37M);
            Console.WriteLine("Total price of the calls: {0:f2} $", price);
            //longest call
            int longestCall = 0;
            foreach (var call in phone.CallHistory)
            {
                if (call.Duration > longestCall)
                {
                    longestCall = call.Duration;
                }
            }
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Longest call is {0} seconds", longestCall);
            //remove longest call
            var callToRemove = new Call("null", 0);
            foreach (var call in phone.CallHistory)
            {
                if (call.Duration == longestCall)
                {
                    callToRemove = call;
                }
            }
            phone.DeleteCall(callToRemove);
            //new total price
            Console.WriteLine(new string('*', 40));
            price = phone.CallPrice(0.37M);
            Console.WriteLine("The new total price is {0:f2} $", price);

            //clear call history
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Clear call history");
            phone.CallHistory.Clear();

            //print call history
            Console.WriteLine("Call history elements: {0}", phone.CallHistory.Count);
        }
    }
}
