using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question3
{
    internal class Program
    {
        delegate double Rounder( double input , int decimals );

        static void Main(string[] args)
        {
            //holds delegate function for Math.Round
            Rounder round = delegate (double input, int decimals) {
                return Math.Round(input, decimals);
            };

            //holds the number to be a double
            double dInput = 0;
            // take input
            Console.WriteLine("Please input a double, we'll round it to the second decimal place");
            string sInput = Console.ReadLine();

            // function is used to validate an input
            Func<string, bool> CheckValid = input =>
            {
                if (double.TryParse(input, out dInput))
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            };

            // while input isn't valid revalidate it
            while (!CheckValid(sInput))
            {
                Console.WriteLine("Please input a valid double number");
                sInput = Console.ReadLine();
            }

            // round the number using a delegate
            dInput = round(dInput, 2);
            // print out the number rounded to the second decimal place
            Console.WriteLine(dInput);
        }
    }
}
