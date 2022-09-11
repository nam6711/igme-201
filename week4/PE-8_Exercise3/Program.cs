using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for a string with the word "no" (case-sensitive)
            Console.WriteLine("Give me some phrase with the word 'no' (case-sensitive): ");
            string sInput = Console.ReadLine();
            // will hold the new string
            string sYes = "";

            // user the .replace() method to create a new string that replaces the word "no" with "yes"
            string[] words = sInput.Split(' ');

            // iterate through all words, replace them if they contain "no"
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("no"))
                {
                    words[i] = "yes";
                }
                sYes += words[i] + " ";
            }

            // print the new string
            Console.WriteLine(sYes);
        }
    }
}
