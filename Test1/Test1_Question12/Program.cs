using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vairable declaration
            string sName;
            double dSalary = 30000;

            //ask for name
            Console.WriteLine("What's your name? ");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congrats on the raise {0}! Your salary is now: {1}!", sName, dSalary);
            }
        }

        static bool GiveRaise(string name, ref double salary)
        {
            // if name == "Nat", give them a raise, otherwise don't
            if (string.Equals(name, "Nat"))
            {
                salary += 19999.99;
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
