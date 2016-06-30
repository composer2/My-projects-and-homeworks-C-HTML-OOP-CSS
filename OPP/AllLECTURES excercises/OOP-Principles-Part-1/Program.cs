using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SimpleInheritance dog cat mamal
            //Dog Bars = new Dog(8, "Labrador");
            //Bars.Sleep();
            //Bars.WagTail();
            //Console.WriteLine("Bars is {0} years old dog of breed {1}.",
            //    Bars.Age, Bars.Breed);
            //Console.WriteLine();
            //Cat Mark = new Cat(3);
            //Mark.Sleep();
            //Mark.SayMay();
            //Console.WriteLine("Mark is {0} years old cat.", Mark.Age);

            ////Inheritance-and-Accessibility dog2 mamal2 creature
            //Dog2 dog2 = new Dog2("Sharo", 6, "labrador");
            //dog2.Sleep(); // Sleep() is public
            //Console.WriteLine("Breed: " + dog2.Breed);
            //dog2.WagTail(); // WagTail() is internal
            //            //joe.Talk(); // This will not compile - Talk() is private
            ////joe.Walk(); // This will not compile - Walk() is protected
            ////Console.WriteLine("Name: " + joe.Name); // Name is protected property

            ////interfaces circle imoveble iresizevle ishape rectangle squeare playwithInterfaces
            //Square square = new Square(0, 0, 10);
            //Rectangle rect = new Rectangle(0, 0, 10, 12);
            //Circle circle = new Circle(0, 0, 5);
            //if (square is IShapecs)
            //{
            //    Console.WriteLine("{0} is IShape", square.GetType());
            //}
            //if (rect is IResizable)
            //{
            //    Console.WriteLine("{0} is IResizable", rect.GetType());
            //}
            //if (circle is IResizable)
            //{
            //    Console.WriteLine("{0} is IResizable", circle.GetType());
            //}
            //IShapecs[] shapes = { square, rect, circle };
            //foreach (IShapecs shape in shapes)
            //{
            //    shape.SetPosition(5, 5);
            //    Console.WriteLine("Type: {0};  surface: {1}",
            //        shape.GetType(), shape.CalculateSurface());
            //}

            ////Abstract-Classes animal cat2 cheetah kitten turtle  tomcat
            //Turtle turtle = new Turtle();
            //Console.WriteLine(turtle);
            //Console.WriteLine("The {0} can go {1} km/h ",
            //    turtle.GetName(), turtle.Speed);
            //Console.WriteLine();
            //Cheetah cheetah = new Cheetah();
            //Console.WriteLine(cheetah);
            //Console.WriteLine("The {0} can go {1} km/h ",
            //    cheetah.GetName(), cheetah.Speed);
            //Console.WriteLine();
            //Tomcat tomcat = new Tomcat();
            //Console.WriteLine(tomcat);
            //Console.WriteLine("The {0} can go {1} km/h ",
            //    tomcat.GetName(), tomcat.Speed);
            //tomcat.SayMyaau();
            //Console.WriteLine();
            //Kitten kitten = new Kitten();
            //Console.WriteLine(kitten);
            //Console.WriteLine("The {0} can go {1} km/h ",
            //    kitten.GetName(), kitten.Speed);
            //kitten.SayMyaau();
            //// This wil not compile (Cat is abstract -> cannot be instantiated)
            ////Cat cat = new Cat();

            // Class-Diagrams- Color,FilledRectangle, Rectangle2,FilledSquare

            ////Encapsulation Person.cs
            //Person p = new Person("Bay Ivan", 73);
            //Console.WriteLine(p);
        }
    }
}
