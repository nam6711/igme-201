using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSortV1
{
    static internal class Program
    {

        static void Main(string[] args)
        {
            double[] aUnsorted;
            double[] aSorted;

            start:
            Console.WriteLine("Enter a list of space-seperated numbers");

            string sNumberString = Console.ReadLine();

            string[] sNumbers = sNumberString.Split(' ');

            int nUnsortedLength = 0;
            double nThisNumber = 0;

            foreach(string sThisNumber in sNumbers)
            {
                if(sThisNumber.Length == 0)
                {
                    continue;
                }

                try
                {
                    nThisNumber = double.Parse(sThisNumber);
                } catch
                {
                    Console.WriteLine($"Number #{nUnsortedLength} is not a valid number.");
                    goto start;
                }
                ++nUnsortedLength;
            }

            aUnsorted = new double[nUnsortedLength];

            nUnsortedLength = 0;

            foreach (string sThisNumber in sNumbers)
            {
                if (sThisNumber.Length == 0)
                {
                    continue;
                }

                nThisNumber = double.Parse(sThisNumber);
                aUnsorted[nUnsortedLength] = nThisNumber;
                ++nUnsortedLength;
            }

            aSorted = new double[nUnsortedLength];

            int nSortedLength = 0;
            while(aUnsorted.Length > 0)
            {
                aSorted[nSortedLength] = FindLowestValue(aUnsorted);

                RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);

                ++nSortedLength;
            }
        }

        static double FindLowestValue(double[] array)
        {
            double returnVal = array[0];

            foreach(double thisNum in array)
            {
                if (thisNum < returnVal)
                {
                    returnVal = thisNum;
                }
            }

            return returnVal;
        }

        static void RemoveUnsortedValue(double removeValue, ref double[] array)
        {

        }
    }
}
