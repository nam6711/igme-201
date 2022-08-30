using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double nStartRealCoord, nStartImagCoord; // used to hold the initial position of the Mandelbrot
            string sRealCoord, sImagCoord; //strings to hold the users inputs for the Mandelbrot
            double realTemp, imagTemp, realTemp2, arg;
            int iterations

            //Prompt and Validate the realCoord from user
            Console.WriteLine("Please input a start X coordinate for the Mandelbrot!\nThe normal start position is -0.6: ");
            do
            {
                sRealCoord = Console.ReadLine();
            } while (!double.TryParse(sRealCoord, out nStartRealCoord));

            //Prompt and Validate the imagCoord from user
            Console.WriteLine("Please input a start Y coordinate for the Mandelbrot!\nThe normal start position is 1.2: ");
            do
            {
                sImagCoord = Console.ReadLine();
            } while (!double.TryParse(sImagCoord, out nStartImagCoord));

            for (imagCoord = nStartImagCoord; imagCoord >= nStartImagCoord - (0.05 * 48); imagCoord -= 0.05)
            {
                for (realCoord = nStartRealCoord; realCoord <= nStartRealCoord + (0.03 * 80); realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}