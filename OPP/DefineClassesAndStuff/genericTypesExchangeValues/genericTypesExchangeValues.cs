﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericTypesExchangeValues
{
    public class CommonOperations<T>
    {
        public void Swap<K>(ref K a, ref K b)
        {
            K oldA = a;
            a = b;
            b = oldA;
        }

        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;
            Console.WriteLine("Before swap: {0} {1}", num1, num2);
            // Invoking the method with concrete type (int)
            Swap(ref num1 , ref num2 );
            Console.WriteLine("After swap: {0} {1}\n", num1, num2);

            string str1 = "Hello";
            string str2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", str1, str2);
            // Invoking the method with concrete type (string)
            Swap(ref str1, ref str2);
            Console.WriteLine("After swap: {0} {1}!", str1, str2);
        }
    }
}
