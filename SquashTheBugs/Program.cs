using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 
            //int i = 0;      //compile time error missing semicolon
            double i = 0;     //logic error should be a double not an int

            //ADDED A LINE from line 30
            string allNumbers = null;       //logic error the data needs to be outside the for-loop

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;     //logic error, the stored data will be lost if the variable is declared here
                //moved this line to line 23

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write($"{i}/{i - 1} = ");       //compile time error the string won't read the data correctly as the syntax is flawed

                // output the calculation based on the numbers
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Does Not Exist");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1     //logic error the for-loop already incriments i and as a result you skip numbers
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
