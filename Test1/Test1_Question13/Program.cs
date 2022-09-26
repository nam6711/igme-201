using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Question12
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            //vairable declaration
            employee worker;
            worker.dSalary = 30000;

            //ask for name
            Console.WriteLine("What's your name? ");
            worker.sName = Console.ReadLine();

            if (GiveRaise(worker.sName, ref worker.dSalary))
            {
                Console.WriteLine("Congrats on the raise {0}! Your salary is now: {1}!", worker.sName, worker.dSalary);
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
