using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_VariablesAndExponents
{
    // Author: Noah Manoucheri
    // Purpose: Method that takes inputs from the user
    //          and prints the product to the console
    // Limitations: None
    internal class Program
    {
        // Author: Noah Manoucheri
        // Purpose: Method that takes inputs from the user
        //          and prints the product to the console
        // Limitations: None
        static void Main(string[] args)
        {
            // Initialize a variable to hold the value of all inputs
            int nProduct = 0;

            // Ask user for 4 inputs
            // use of a for loop to get inputs, and a while loop to authenticate them
            for (int i = 0; i < 4; i++)
            {
                // creates a temp variable to hold the
                // input before being added into the total
                int nUserInput = 0;

                // prompt the user
                Console.Write($"Give me number {i + 1} to add:  ");
                // hold user input
                string sInput = Console.ReadLine();

                // use a while loop to validate the input as a number
                while (!int.TryParse(sInput, out nUserInput))
                {
                    //prompt the user again if input isn't valid
                    Console.WriteLine("Please input a valid number:  ");

                    // try to convert number to a 32 bit intiger
                    sInput = Console.ReadLine();
                
                // while the input isn't null/isn't valid retry input taking
                };

                // add user input to the total value of inputs
                nProduct += nUserInput;
            }

            // print final total value of all inputs
            Console.WriteLine("The value of your four inputs is:  " + nProduct);

        }
    }
}
