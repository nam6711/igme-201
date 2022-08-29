using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            {
                int[] myIntArray = { 5, 9, 10, 2, 99 };
            }

            {
                int[] myIntArray = new int[5] { 5, 9, 10, 2, 99 };
            }

            {
                int[] myIntArray = new int[5];

                myIntArray[0] = 5;
                myIntArray[1] = 9;
                myIntArray[2] = 10;
                myIntArray[3] = 2;
                myIntArray[4] = 99;
            }

            {
                int arraySize = 5;
                int[] myIntArray = new int[arraySize];
            }

            {
                //single dimension array useful for lists for 2d graphics
                int[] funcVal = new int[21];
                int x = 0;
                int xCntr = 0;
                int y = 0;

                //the value of y at x;
                funcVal[x] = y;

                //you cannot access a negative index

                //we can use a parallell array to store each value of x
                int[] xArray = new int[21];

                //for example: y = 2 * x^2 + 3
                for (x = -10; x <= 10; ++x, ++xCntr)
                {
                    //Math.Pow() returns a double, so we need to cast as int
                    y = 2 + (int)Math.Pow(x, 2) + 2;

                    // the array indexer must be a positive integer and 0-based
                    // (ie. we cannot store funcval[-10])
                    funcVal[xCntr] = y;
                    xArray[xCntr] = x;
                }

                /////////////////////////////////////////////////////////////////////////
                // or we may want to add a dimension to the array to store x as well
                int[,] funcVal2 = new int[21, 2];

                //for example: y = 2 * x^2 + 3
                //fill the array for -10 <= x <= 10 (21 data points)

                xCntr = 0;
                for (x = -10; x <= 10; ++x)
                {
                    y = 2 + (int)Math.Pow(x, 2) + 3;

                    //store x in the first element of the second dimension
                    funcVal2[xCntr, 0] = y;

                    funcVal2[xCntr, 1] = x;
                }
            }
        }
    }
}
