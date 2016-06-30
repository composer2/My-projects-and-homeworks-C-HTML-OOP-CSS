using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_BoxingUnboxing
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int value1 = 1;
            object obj = value1;//boxing performed

            value1 = 12345;//only stack value is changed

            int value2 = (int)obj;//unboxing performed
            Console.WriteLine(value2);

            long value3 = (long)(int)obj;//unboxing
            Console.WriteLine(value3);
            //long value4 = (long)obj;//InvalidCastException
            //Console.WriteLine(value4);

            Point p1 = new Point();
            Console.WriteLine("p1={0}", p1);

            IMovable p1mov = (IMovable)p1; //p1 is boxed
            IMovable p2mov = (IMovable)p1mov;
            // p1mov is not boxed second time,
            // because it is already boxed

            Point p2 = (Point)p2mov;//p2mov is unboxed
            p1.Move(-100, -100);
            p2.Move(100, 100);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p1mov.Move(5, 5);
            Console.WriteLine(p1mov);
            Console.WriteLine(p2mov);


        }
    }
}
