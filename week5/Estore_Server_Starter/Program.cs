using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estore_Server_Starter
{
    static internal class Program
    {
        // delegate for choosing which menu to display
        delegate void Menu(ref int opt, ref Menu menu);

        // MainMenu:
        // Provides all options for navigating the program
        static void MainMenu(ref int opt, ref Menu menu)
        {
            // create a bool to hold whether the menu has changed
            bool bMenuChange = false;

            // Prompt the user!
            Console.WriteLine("Navigate with arrow keys and select with 'ENTER'");
            // Display options, and highlight the correct option
            Console.WriteLine("{0} Run Both", (opt == 0) ? ">  " : "1. ");
            Console.WriteLine("{0} Run Estore_API", (opt == 1) ? ">  " : "1. ");
            Console.WriteLine("{0} Run Estore_UI", (opt == 2) ? ">  " : "2. ");
            Console.WriteLine("{0} Options (Change Directories)", (opt == 3) ? ">  " : "3. ");

            // check the user's inputs
            bMenuChange = MenuSelect(ref opt, 3);

            // if enter is hit on option, change to the correct task
            //      0 - run Both
            //      1 - run API
            //      2 - run UI
            //      3 - run Options && set opt to 0
            if (bMenuChange && opt == 0)
            {
                RunAPI();
                RunUI();
            }
            else if (bMenuChange && opt == 1)
            {
                RunAPI();
            }
            else if (bMenuChange && opt == 2)
            {
                RunUI();
            }
            else if (bMenuChange && opt == 3)
            {
                menu = new Menu(Options);
                opt = 0;
            }
        }

        // Options:
        // Provides all options for navigating the program
        static void Options(ref int opt, ref Menu menu)
        {
            // create a bool to hold whether the menu has changed
            bool bMenuChange = false;

            // create a stream reader to hold the UI locations to display
            StreamReader e = new StreamReader("Directories.txt");

            // save all contents to an array, then close the stream
            string[] contents = { e.ReadLine(), e.ReadLine() };
            e.Close();

            // Prompt the user!
            Console.WriteLine("Navigate with arrow keys and select with 'ENTER'");
            // Display options and current directories, and highlight the correct option
            Console.WriteLine("{0} BACK", (opt == 0) ? ">  " : "1. ");
            Console.WriteLine("{0} Set Estore_API Directory    (CURRENT: {1})", (opt == 1) ? ">  " : "2. ", contents[0]);
            Console.WriteLine("{0} Set Estore_UI Directory     (CURRENT: {1})", (opt == 2) ? ">  " : "3. ", contents[1]);

            // check the user's inputs
            bMenuChange = MenuSelect(ref opt, 2);

            // if enter is hit on option, change to the correct task
            //      0 - go BACK && set opt back to 0
            //      1 - run set API Dir
            //      2 - run set UI Dir
            if (bMenuChange && opt == 0)
            {
                menu = new Menu(MainMenu);
                opt = 0;
            }
            else if (bMenuChange && opt == 1)
            {
                ChangeAPI();
                opt = 0;
            }
            else if (bMenuChange && opt == 2)
            {
                ChangeUI();
                opt = 0;
            }
        }

        // MenuSelect:
        // reads user input for menu
        static bool MenuSelect(ref int opt, int max)
        {
            // holds the key pressed
            ConsoleKeyInfo key;

            // reads user input and returns a value that changes the nOption ref
            // if up is pressed, decriment the value
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                // if opt goes over the max, or below 0, wrap around
                if (opt == 0)
                {
                    opt = max;
                }
                else
                {
                    opt--;
                }
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                // if opt goes over the max, or below 0, wrap around
                if (opt == max)
                {
                    opt = 0;
                }
                else
                {
                    opt++;
                }
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                //if enter is hit return true
                return true;
            }
            // if enter isn't hit, return false
            return false;
        }

        static void Main(string[] args)
        { 
            // variable to hold menu selected
            // ******* MENUS *******
            // MainMenu
            // Options
            Menu menu = new Menu(MainMenu);

            // variable to hold menu option selected
            int nOption = 0;

        start:
            // Displays the correct Menu
            menu(ref nOption, ref menu);

            // loop back to start and clear console
            Console.Clear();
            goto start;
        }

        // RunAPI:
        // opens a command prompt and uses the saved directory within
        // directories.txt to find it
        static void RunAPI()
        {
            // initialize a stream reader
            StreamReader e = new StreamReader("Directories.txt");

            // read line 1 to find the directory, and save it to a variable
            string directory = e.ReadLine();

            // close stream
            e.Close();

            // create the command to run in the command prompt
            string command = @"/C cd " + directory + " & mvn compile exec:java";

            // create a new command terminal
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"C:\",
                WindowStyle = ProcessWindowStyle.Normal,
                UseShellExecute = true,
                CreateNoWindow = false,
                Arguments = command
            };
            Process api = new Process { StartInfo = startInfo };

            // run the command "cd *directory*"
            // run the command "mvn compile exec:java"
            api.Start();
        }


        // ChangeAPI:
        // Takes user input and edits the current directory for the API
        static void ChangeAPI()
        {
            // create a StreamReader to store the file's contents
            // before editing them
            StreamReader e = new StreamReader("Directories.txt");

            // array to store the contents of the stream
            string[] contents = { e.ReadLine() , e.ReadLine() };

            // close StreamReader
            e.Close();

            // prompt user for directory 1
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Input the Location of your API program:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            contents[0] = Console.ReadLine().Trim();

            // create a StreamWriter
            StreamWriter f = new StreamWriter("Directories.txt");

            // iterate over array of contents and write them to the file
            f.WriteLine(contents[0]);
            f.WriteLine(contents[1]);

            // save it and close the stream
            f.Close();
        }

        // RunUI:
        // opens a command prompt and uses the saved directory within
        // directories.txt to find it
        static void RunUI()
        {
            // initialize a stream reader
            StreamReader e = new StreamReader("Directories.txt");

            // read line 2 to find the directory, and save it to a variable
            e.ReadLine();
            string directory = e.ReadLine();

            // close stream
            e.Close();

            // create the command to run in the command prompt
            string command = @"/C cd " + directory + " & ng serve --open";

            // create a new command terminal
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"C:\",
                WindowStyle = ProcessWindowStyle.Normal,
                UseShellExecute = true,
                CreateNoWindow = false,
                Arguments = command
            };
            Process api = new Process { StartInfo = startInfo };

            // run the command "cd *directory*"
            // run the command "mvn compile exec:java"
            api.Start();
        }

        // ChangeUI:
        // Takes user input and edits the current directory for the UI
        static void ChangeUI()
        { 
            // create a StreamReader to store the file's contents
            // before editing them
            StreamReader e = new StreamReader("Directories.txt");

            // array to store the contents of the stream
            string[] contents = {e.ReadLine(), e.ReadLine()};

            // close StreamReader
            e.Close();

            // prompt user for directory 2
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Input the Location of your UI program:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            contents[1] = Console.ReadLine().Trim();

            // create a StreamWriter
            StreamWriter f = new StreamWriter("Directories.txt");

            // iterate over array of contents and write them to the file
            f.WriteLine(contents[0]);
            f.WriteLine(contents[1]);

            // save it and close the stream
            f.Close();
        }
    }
}
