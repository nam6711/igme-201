using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt user for a string
            Console.WriteLine("Give me a string");
            string sInput = Console.ReadLine();

            // create a string to hold the reversed string order
            string sReverse = "";

            // for-loop that goes reverse order through a string
            for (int i = sInput.Length; i > 0; i--)
            {
                // save the current string character onto the temp var
                sReverse += sInput[i - 1];
            }

            // print the var
            Console.WriteLine(sReverse);
        }
    }
}
