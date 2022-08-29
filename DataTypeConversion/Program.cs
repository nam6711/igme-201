using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    internal class Examples
    { 
        // Class: Examples
        // Author:Noah Manoucheri
        // Purpose: Examples for Week 2
        // Restrictions: Only conains code snippits

        static void Main(string[] args)
        {
            // Method: Main
            // Purpose: The main entry point for our program. Contains code snippits
            // Restrictions: None

            /////////////////////////////////////////////////////
            // Conversion Overflow Checking
            /////////////////////////////////////////////////////
            {
                // implicit catalog
                // you can set any data type = args lesser data type
                double doubleNum = 9999.999;
                float floatNum = 999.9F;
                /**
                long
                ulong
                int     // int32
                uint    // Uint32
                short   // int16
                ushort  // Uint16
                byte    // 8-bit unsigned
                sbyte   // 8-bit signed

                string
                bool
                */

                //Explicit Casting
                // you can explicitly cast but
                // the source data will be truncated if it does not fit in the target variable
                // byteNum will only hold the lowest 8 buts of 16-bit shortInt

                //Convert to int32()
                // we can also explicitly cast using the Convert Class
                // will raise a run-time exception if data will be lost

                //convert strings to numbers
            }
        }
    }
}
