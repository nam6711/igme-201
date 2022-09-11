using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt user for a string
            Console.WriteLine("Give me a phrase");
            string sInput = Console.ReadLine();
            // variable to hold final list of words
            string sFinal = "";

            // split string into an array of words
            string[] words = sInput.Split(' ');

            // for loop iterates through array
            //      add in '\"' to the ends of each word
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = "\"" + words[i] + "\"";
                sFinal += words[i] + " ";
            }

            // print out new word
            Console.WriteLine(sFinal);
        }
    }
}
