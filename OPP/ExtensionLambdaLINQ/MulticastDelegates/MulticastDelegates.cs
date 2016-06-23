using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate int StringDelegate<T>(T value);
    class MulticastDelegate
    {
        private static int PrintString(string str)
        {
            Console.WriteLine("STR: {0}", str);
            return 1;
        }
        private int PrintStringLength(string value)
        {
            Console.WriteLine("Length: {0}", value.Length);
            return 2;
        }
        public static void Main(string[] args)
        {
            StringDelegate<string> d = MulticastDelegate.PrintString;
            MulticastDelegate instance = new MulticastDelegate();
            d += instance.PrintStringLength;
            d += delegate (string str)
            {
                Console.WriteLine("Uppercase: {0}", str.ToUpper());
                return 3;
            };
            int result = d("some string value");
            Console.WriteLine("Returned result: {0}", result);

            Func<string, int> predefinedIntParse = int.Parse;
            int number = predefinedIntParse("10");
            Console.WriteLine(number);

            Action<object> predefinedAction = Console.WriteLine;
            predefinedAction("1000");
        }
    }
}
