using System;
using System.Linq;
namespace array
{
    class array
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long result = 0;
            double lines = 0.0;
            int startIndex = 0;
            while (true)
            {
                var comands = Console.ReadLine().Split();
                if (comands[0] == "stop")
                {
                    break;
                }
                int repeats = int.Parse(comands[0]);
                var direction = comands[1];
                var steps = int.Parse(comands[2]);
                while (repeats > 0)
                {
                    if (direction == "right")
                    {
                        startIndex = (startIndex + steps) % numbers.Length;
                        result += numbers[startIndex];
                    }
                    else if (direction == "left")
                    {
                        startIndex =startIndex- steps;
                        if (startIndex < 0)
                        {
                            startIndex = numbers.Length + (startIndex % numbers.Length);
                            if (startIndex == numbers.Length)
                            {
                                startIndex = 0;
                            }
                        }
                        result += numbers[startIndex];
                    }
                    repeats--;
                }
                lines++;
            }
            Console.WriteLine("{0:f1}",result/lines);
        }
    }
}