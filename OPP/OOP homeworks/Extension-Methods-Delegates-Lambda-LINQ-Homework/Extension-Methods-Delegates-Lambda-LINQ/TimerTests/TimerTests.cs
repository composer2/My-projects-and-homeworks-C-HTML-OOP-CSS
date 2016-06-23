using AllClassesAndStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTests
{
    class TimerTests
    {
        static void Main(string[] args)
        {
            //adding methods to delegate and creating Timer objects that use delegates
            TimerEvent firstEvent = MessageEveryNSeconds;
            AllClassesAndStruct.Timer firstTimer = new AllClassesAndStruct.Timer(5, firstEvent);

            TimerEvent secondEvent = MessageEveryNSeconds;
            AllClassesAndStruct.Timer secondTimer = new AllClassesAndStruct.Timer(10, secondEvent);

            //executing methods in delegates
            Thread firstThread = new Thread(firstTimer.ExecuteTask);
            firstThread.Start();

            Thread secondThread = new Thread(secondTimer.ExecuteTask);
            secondThread.Start();
        }

        //test methods
        private static void MessageEveryNSeconds(int period)
        {
            Console.WriteLine("Message at every {0}th miliseconds.", period);
        }
    }
}
