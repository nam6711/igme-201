using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Delegates
{
    internal class Program
    {
        //creates a delagate
        delegate string TakeInput();

        static void Main(string[] args)
        {
            // create a delagte variable
            // point the delegate to its proper method
            TakeInput inputTaker = new TakeInput(Console.ReadLine);

            Console.WriteLine("This program uses a delegate to read your input");
            //take input
            string input = inputTaker();
            //print input
            Console.WriteLine(input);


        }
    }
}
