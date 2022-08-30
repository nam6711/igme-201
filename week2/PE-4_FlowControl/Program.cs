using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_4_FlowControl
{
    // Class: Program
    // Author: Noah Manoucheri
    // Restrictions: Code Snippets
    internal class Program
    {
        // Method: Main
        // Purpose: Take two inputs from the user (intigers) and compare them
        //          to see if they're both greater than 10. If only ONE is greater
        //          than 10, print a end program. Otherwise, prompt the user again
        // Restrictions: None
        static void Main(string[] args)
        {
            // Prompt user for two numbers 
            Console.WriteLine("Give me two numbers, one greater than 10, and one less than 10: ");

            // Create two int vars to hold user inputs
            int var1;
            int var2;
            string sInput1;
            string sInput2;

            // AND validate answers as real numbers
            do
            {
                Console.Write("Number 1: ");
                sInput1 = Console.ReadLine();
            } while (!int.TryParse(sInput1, out var1));
            do
            {
                Console.Write("Number 2: ");
                sInput2 = Console.ReadLine();
            } while (!int.TryParse(sInput2, out var2));

            // Prompt user for new inputs if the check fails
            // Check to see if only one is greater than 10
            while ((var1 > 10 && var2 > 10) || (var1 < 10 && var2 < 10))
            {
                Console.WriteLine("Invalid Answer, please give me ONE number GREATER THAN 10 and ONE number LESS THAN 10: ");
                // validate answers as real numbers
                do
                {
                    Console.Write("Number 1: ");
                    sInput1 = Console.ReadLine();
                } while (!int.TryParse(sInput1, out var1));
                do
                {
                    Console.Write("Number 2: ");
                    sInput2 = Console.ReadLine();
                } while (!int.TryParse(sInput2, out var2));
            }

            //Print a success message
            Console.WriteLine($"You input {var1} and {var2}! One is less than 10, and one is greater than 10!");
        }
    }
}
