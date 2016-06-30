using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Polymorphism square rectangle figure circle
            //Figure[] figures =
            //{
            //     new Square { Size = 3 },
            //     new Circle { Radius = 2 },
            //     new Rectangle { Width = 2, Height = 3 },
            //     new Circle { Radius = 3.5 },
            //     new Square { Size = 2.5 },
            //     new Square { Size = 4 },
            //};
            //foreach (Figure item in figures)
            //{
            //    Console.WriteLine("Figure = {0} surface = {1:f2}", item.GetType().Name.PadRight(9, ' '), item.CalcSurface());
            //}

            ////virtual methods figure2 circle2 line specialFigure
            //Figure2[] figures2 =
            //{
            //    new Line(),
            //    new Circle2(),
            //    new Line(),
            //    new SpecialFigure(),
            //    new Line(),
            //};
            //foreach (var item in figures2)
            //{
            //    item.Draw();
            //    Console.WriteLine();
            //}

            // //Exception  SimpleExceptionClass program static smtng
            // Console.WriteLine(CalcSize(new Rectangle {Width=3.3,Height=5.2 }));
            // Console.WriteLine(CalcSize(new Circle {Radius=1.5 }));
            // Console.WriteLine(CalcSize("Hello"));
            // Console.WriteLine(CalcSize(42));
            // Console.WriteLine(CalcSize(1.5555)); 
            //// compile error Console.WriteLine(CalcSize(DateTime.Now));

            ////User-Defined-Exception SumOfLines ParseFileException 
            //long sumOfLines = CalculateSumOfLines(@"..\..\test.txt");
            //Console.WriteLine("The sum of lines={0}", sumOfLines);

            
        }
        private static double CalcSize(object obj)
        {
            // To use the class Figure first add a reference to the project where it is defined!
            if (obj is Figure)
            {
                return ((Figure)obj).CalcSurface();
            }

            if (obj is string)
            {
                return ((string)obj).Length;
            }

            try
            {
                return (double)(dynamic)obj;
            }
            catch (Exception ex)
            {
                throw new InvalidCalculationException("Cannot calculate the size of the specified object", ex);
            }
        }
        private static long CalculateSumOfLines(string fileName)
        {
            StreamReader inFile;
            try
            {
                inFile = File.OpenText(fileName);
            }
            catch (IOException ioe)
            {
                string message = string.Format("Cant open the file {0} for reading", fileName);
                throw new ParseFileException(message, fileName, ioe);
            }
            using (inFile)
            {
                long sum = 0;
                long lineNumber = 0;
                while (true)
                {
                    lineNumber++;
                    string line;
                    try
                    {
                        line = inFile.ReadLine();
                    }
                    catch (IOException ioe)
                    {

                        throw new ParseFileException("Error reading from file.", fileName, lineNumber, ioe);
                    }

                    if (line == null)
                    {
                        break;
                    }

                    try
                    {
                        sum += int.Parse(line);
                    }
                    catch (SystemException se)
                    {
                        var message = string.Format("Error parsing the line '{0}'.", line);
                        throw new ParseFileException(message, fileName, lineNumber, se);
                    }
                }
                return sum;
            }
        }
    }
}