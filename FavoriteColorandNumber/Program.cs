using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteColorandNumber
{
    internal class Program
    {
        static void PrintMyColor(string sColorString)
        {
            // sColorString is a local string to this method
            // which will recieve a copy of the passed variable from the colling method
            // append " is your favorite color" to sColorString, which will change the variable in the calling method
            // 
        }

        static void PrintMyColorReference(ref string sColorString)
        {
            // sColorString is a local string to this method
            // which will recieve a copy of the passed variable from the colling method
            // append " is your favorite color" to sColorString, which will change the variable in the calling method
            // 
        }

        static void Main(string[] args)
        {
            string sFavColor = null;

            sFavColor = Console.ReadLine();

            PrintMyColor(sFavColor);
            PrintMyColorReference(ref sFavColor);

            int? nFavNumber = null;
            Console.WriteLine("What's your favorite number?");


        }
    }
}
