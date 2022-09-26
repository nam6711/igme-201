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
            Rounder round = new Rounder(Math.Round);

            //holds the number to be a double
            double dInput;

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
        }
    }
}
