using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class AbstractClasses
    {
        static void Main(string[] args)
        {
            Turtle turtle = new Turtle();
            Console.WriteLine(turtle);
            Console.WriteLine("The {0} can go {1}km/h",turtle.GetName(),turtle.Speed);
            Console.WriteLine();

            Cheetah cheetah = new Cheetah();
            Console.WriteLine(cheetah);
            Console.WriteLine("The {0} can go {1}km/h", cheetah.GetName(), cheetah.Speed);
            Console.WriteLine();

            Tomcat tomcat = new Tomcat();
            Console.WriteLine(tomcat);
            Console.WriteLine("The {0} can go {1} km/h ",
                tomcat.GetName(), tomcat.Speed);
            tomcat.SayMyauu();

            Console.WriteLine();

            Kitten kitten = new Kitten();
            Console.WriteLine(kitten);
            Console.WriteLine("The {0} can go {1} km/h ",
                kitten.GetName(), kitten.Speed);
            kitten.SayMyauu();
        }
    }
}
