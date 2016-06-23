using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron3D
{
    class Tron3D
    {
        static int oldx, oldy, oldz;
        static string redMoves, blueMoves;
        static int X, Y;
        static bool[,] used;
        static int currentRedX;
        static int currentRedY;
        static int currentBlueX;
        static int currentBlueY;
        //directions
        static int redDirection; //right
        static int blueDirection; //left


        static void Main(string[] args)
        {
            ReadInput();
            X = oldx;
            Y = oldy + oldz + oldy + oldz;
            used = new bool[X + 1, Y];
            currentRedX = oldx / 2;
            currentRedY = oldy / 2;

            currentBlueX = oldx / 2;
            currentBlueY = oldy + oldz + oldy / 2;

            redDirection = 0; //right
            blueDirection = 2; //left 

            var redIndex = 0;
            var blueIndex = 0;


            while (true)
            {
                #region MoveRed
                int newRedX = currentRedX;
                int newRedY = currentRedY;

                //direction
                while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
                {
                    if (redMoves[redIndex] == 'L')
                    {
                        redDirection = RotateLeft(redDirection);
                    }
                    else //if (redMoves[redIndex]=='R')
                    {
                        redDirection = RotateRight(redDirection);
                    }
                    redIndex++;
                }
                //move
                MovePlayer(ref newRedX, ref newRedY, redDirection);
                redIndex++;
                #endregion
                #region MoveBlue
                int newBlueX = currentBlueX;
                int newBlueY = currentBlueY;
                while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
                {
                    if (blueMoves[blueIndex] == 'L')
                    {
                        blueDirection = RotateLeft(blueDirection);
                    }
                    else //if (blueMoves[blueIndex]=='R')
                    {
                        blueDirection = RotateRight(blueDirection);
                    }
                    blueIndex++;
                }
                //move
                MovePlayer(ref newBlueX, ref newBlueY, blueDirection);
                blueIndex++;
                #endregion
                #region Y red coords
                if (newRedY >= Y)
                {
                    newRedY = 0;
                }
                if (newRedY < 0)
                {
                    newRedY = Y - 1;
                }
                #endregion
                #region Y blue coords
                if (newBlueY >= Y)
                {
                    newBlueY = 0;
                }
                if (newBlueY < 0)
                {
                    newBlueY = Y - 1;
                }
                #endregion

                bool redLoses = Loses(newRedX, newRedY);
                bool blueLoses = Loses(newBlueX, newBlueY);

                if (redLoses && blueLoses)
                {
                    Console.WriteLine("DRAW");
                }
                else if (redLoses)
                {
                    Console.WriteLine("BLUE");
                }
                else if (blueLoses)
                {
                    Console.WriteLine("RED");
                }

                currentRedX = newRedX;
                currentRedY = newRedY;

                currentBlueX = newBlueX;
                currentBlueY = newBlueY;

                if (redLoses || blueLoses)
                {
                    int startRedX = oldx / 2;
                    int startRedY = oldy / 2;
                    int diffRedYLeft = startRedY + (Y - currentRedY+1);
                    int diffRedYRight = Math.Abs(currentRedY - startRedY);


                    int diffRedX = Math.Abs(currentRedX - startRedX);
                    int diffRedY = Math.Min(diffRedYLeft, diffRedYRight);
                    int diffRed = diffRedX - diffRedY;
                    if (redLoses && blueLoses)
                    {
                        Console.WriteLine(diffRed-1);
                    }
                    else
                    {
                    Console.WriteLine(diffRed);
                    }
                    break;
                }
                used[newRedX, newRedY] = true;
                used[newBlueX, newBlueY] = true;
            }
        }
        public static bool Loses(int playerX, int playerY)
        {

            if (playerX < 0)
            {
                return true;
            }

            if (playerX > X)
            {
                return true;
            }

            if (used[playerX, playerY])
            {
                return true;
            }
            return false;
        }
        public static void MovePlayer(ref int currentX, ref int currentY, int direction)
        {
            if (direction == 0)
            {
                currentY++;
            }
            else if (direction == 1)
            {
                currentX++;
            }
            else if (direction == 2)
            {
                currentY--;
            }
            else if (direction == 3)
            {
                currentX--;
            }
        }
        public static void ReadInput()
        {
            string xyz = Console.ReadLine();
            var xyzIndex = xyz.Split();
            oldx = int.Parse(xyzIndex[0]);
            oldy = int.Parse(xyzIndex[1]);
            oldz = int.Parse(xyzIndex[2]);
            redMoves = Console.ReadLine();
            blueMoves = Console.ReadLine();
        }
        static int RotateLeft(int direction)
        {
            int newDirection = direction - 1;
            if (newDirection == -1)
            {
                newDirection = 3;
            }
            return newDirection;
        }
        static int RotateRight(int direction)
        {
            int newDirection = direction + 1;
            if (newDirection == 4)
            {
                newDirection = 0;
            }
            return newDirection;
        }
    }
}
