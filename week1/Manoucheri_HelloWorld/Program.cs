using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manoucheri_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Jada Pinkett Smith");

            int numberOne = 10;
            int numberTwo = 20;
            Console.WriteLine(numberOne + numberTwo);

            if (numberOne > 12)
            {
                Console.WriteLine("The first number is small isn't it");
            }
            else if (numberTwo < 25)
            {
                Console.WriteLine("The second number is small isn't it");
            }

            bool testBoolean = true;
            while (testBoolean)
            {
                if (numberOne < 20)
                {
                    numberOne++;
                    Console.WriteLine("numberOne is now " + numberOne);
                }
                else
                {
                    Console.WriteLine("number one is finally more than 20");
                    testBoolean = false;
                }
            }
        }
    }
}
