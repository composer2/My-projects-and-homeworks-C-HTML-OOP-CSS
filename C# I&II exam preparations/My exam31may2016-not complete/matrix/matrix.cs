using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class matrix
    {
        static void Main(string[] args)
        {
            var dimensionSizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] dimmensions = new int[4][];
            dimmensions[0] = new int[dimensionSizes[0]];
            dimmensions[1] = new int[dimensionSizes[1]];
            dimmensions[2] = new int[dimensionSizes[2]];
            dimmensions[3] = new int[dimensionSizes[3]];

            var dimensionHarryCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            dimmensions[0][dimensionHarryCoordinates[0]] = 64;
            dimmensions[1][dimensionHarryCoordinates[1]] = 64;
            dimmensions[2][dimensionHarryCoordinates[2]] = 64;
            dimmensions[3][dimensionHarryCoordinates[3]] = 64;

            var basiliks = int.Parse(Console.ReadLine());
            for (int i = 0; i < basiliks; i++)
            {
                var currBasiliks = Console.ReadLine().Split().ToArray();
                dimmensions[0][int.Parse(currBasiliks[1])] = char.Parse(currBasiliks[0]);
                dimmensions[1][int.Parse(currBasiliks[2])] = char.Parse(currBasiliks[0]);
                dimmensions[2][int.Parse(currBasiliks[3])] = char.Parse(currBasiliks[0]);
                dimmensions[3][int.Parse(currBasiliks[4])] = char.Parse(currBasiliks[0]);
            }
            var harrySteps = 0;
            while (true)
            {
                var unitNameInstruction = Console.ReadLine();
                if (unitNameInstruction == "END")
                {
                    break;
                }
                var instructions = Console.ReadLine().Split().ToArray();
                var unit = char.Parse(instructions[0]);
                var dimension = char.Parse(instructions[1]);
                var moves = int.Parse(instructions[2]);

                if (dimension == 65)
                {
                    if (unit==64)
                    {
                        harrySteps++;
                        for (int i = 0; i < dimmensions[0].Length; i++)
                        {
                            if (dimmensions[0][i]==0)
                            {

                            }
                        }
                    }
                    else
                    {

                    }
                }
                else if(dimension == 66)
                {
                    if (unit == 64)
                    {
                        harrySteps++;
                    }
                    else
                    {

                    }
                }
                else if (dimension == 67)
                {
                    if (unit == 64)
                    {
                        harrySteps++;
                    }
                    else
                    {

                    }
                }
                else if (dimension == 68)
                {
                    if (unit == 64)
                    {
                        harrySteps++;
                                       }
                    else
                    {

                    }
                }
            }
        }
    }
}

