using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_MoreAboutVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize double[,,] array for the potential values:
            //      x: -1 <= x <= 1 in 0.1 incriments
            //          length algorithm: ( 1 - ( -1 ) ) / 0.1
            //              20
            //      y: 1 <= x <= 4 in 0.1 incriments
            //          length algorithm: ( 4 - 1 ) / 0.1
            //              30
            //      z: 1 <= x <= 4 in 0.1 incriments
            //          length algorithm: ( 4 - 1 ) / 0.1
            //              20
            double[,,] dAlgorithms = new double[21, 30, 3];

            // create counter variables to hold array positions in for-loops
            int xCount = 0;
            int yzCount = 0;

            // double for-loop that incriments values of x's then values of y's
            //      inside second for loop caluculate the value of z with x and y
            //      store z value in third dimension of the array
            for (double x = -1; x <= 1; x += 0.1)
            {
                for (double y = 1; y <= 4; y += 0.1)
                {
                    // set x, y, and z values for this x position
                    // set x value at this position
                    dAlgorithms[xCount, yzCount, 0] = x;
                    // y val
                    dAlgorithms[xCount, yzCount, 1] = y;
                    // z val
                    //      z = 3y^2 + 2x - 1 
                    dAlgorithms[xCount, yzCount, 2] = (3 * (y * y)) + (2 * x) - 1;

                    // incriment yzCount
                    yzCount++;
                }
                // reset yzCount variable
                yzCount = 0;
                // incriment xCount variable
                xCount++;
            }

            // print the value of each array with equations
            // double for-loop to incriment through the array and print out each equation
            for (int x = 0; x < dAlgorithms.GetLength(0); x++)
            {
                for (int y = 0; y < dAlgorithms.GetLength(1); y++)
                {
                    Console.WriteLine($"{dAlgorithms[x, y, 2]} = ( 3 * {dAlgorithms[x, y, 1]}^2 ) + ( 2 * {dAlgorithms[x, y, 0]} ) - 1");
                }
            }
        }
    }
}
