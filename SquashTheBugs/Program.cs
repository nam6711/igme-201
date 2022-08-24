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
            //Unnecessary as the code can be done inside the for loop on line 27

            //ADDED A LINE from line 30
            string allNumbers = null;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            for (int i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;
                //moved this line to line 23

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write($"{i}/{i - 1} = ");

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
                //i = i + 1;
                //Unnecessary as the for-loop already incriments and as a result you skip numbers
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
