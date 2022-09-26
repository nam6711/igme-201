using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY
            //Syntax error missing identifier ";" (needs a semicolon)
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);
            //Syntax error missing indentifier for string
            Console.WriteLine("This program calculates x ^ y.");
            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));
            // Runtime error, use of a empty variable
            // there's no assigned value, so the program can't use it
            // added a line to assign it a value on line 30

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                //} while (int.TryParse(sNumber, out nX));
            } while (!int.TryParse(sNumber, out nY));
            //Logical and Runtime error
            //the value of nX is assigned where nY should be assigned
            //as well as that, it will never escape the while-loop
            //      as it checks to see if the try-parse succeeded instead of failed
            //      to determine if it needs to revalidate the user input
            // changed the value to nY and added a "!"/"not" boolean operator

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}");
            //  syntax error, requires a '$' in order to inject values
            //  into the string
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");

        }


        //int Power(int nBase, int nExponent)
        //Runtime error, the function requires an object in order to be used
        // added the static tag so that it can be used without initializing an object with the class
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0;
                // logical error, anything to the power of 0 is 1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1);
                //Logical and Runtime error
                //  the expected result should be nExponent-1, they wrote nExponent+1
                //  this results in a StackOverFlowException, as the numbers will never end multiplying
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;
            //Runtime and Logical error, the program does not return any values
            //  added a line that returns the returnVal value
            return returnVal;
        }
    }

}
