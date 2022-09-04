using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE7_MadLibs
{
    // Class: Program
    // Author: Noah Manoucheri
    // Purpose: Create an iteractive MadLibs Program with different stories
    //          that the user can manually write onto
    // Return: stories {string[]} an array of all stories from the "MadLibsTemplate.txt" file
    // Restrictions: none
    internal class Program
    {
        // Method: ValidateNumberInput
        // Purpose: Takes an input from the user and validates it for me
        // Parameters: sInput: the input to validate
        //             nRange: the max number the input should be
        // Restrictions: none
        static string[] InitializeStory()
        {
            // open a stream to the MadLibsTemplate.txt file
            StreamReader sr = new StreamReader("MadLibsTemplate.txt");

            // holds the number of stories
            int storyCount = 0;

            // split up text file into its different stories in an array
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                storyCount++;
            }
            // close steram 
            sr.Close();


            // open a new stream so we can turn all the madlibs stories into a array
            sr = new StreamReader("MadLibsTemplate.txt");
            // create an array to hold all madLibs stories
            string[] stories = new string[storyCount];
            // while loop to store all the stories
            for (int i = 0; i < storyCount; i++)
            {
                stories[i] = sr.ReadLine();
            }
            sr.Close();

            // return the array of stories
            return stories;
        }

        // Method: ValidateInput
        // Purpose: Takes an input from the user and validates it for me
        // Parameters: sInput: the input to validate
        //             nRange: the max number the input should be
        // Return: nInput {int} a number the user selected between 1 - nRange
        // Restrictions: limited to returning intigers
        static int ValidateInput(string sInput, int nRange)
        {
            // holds the int of the users input to be returned
            int nInput;

            // check if input was a string, then check if it was within the allotted range
            while (!int.TryParse(sInput, out nInput) || (nInput < 1 || nInput > nRange))
            {
                // prompt the user for a new input
                Console.WriteLine("Please input a valid number from 1 to {0}", nRange);
                sInput = Console.ReadLine();
            }

            // returns whether the input was valid or not
            return nInput;
        }

        // Method: ValidateInput
        // Purpose: Takes an input from the user and validates it for me
        // Return: bool {bool} a true or false value based on the user's input
        // Restrictions: limited to returning booleans based on strings
        static bool ValidateInput()
        {
            // bool to keep track if a valid input has been entered
            bool bValid;

            // variable to keep track of how many times the user has an invalid input
            int nCntr = 0;

            // prompt the user to play again
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Would you like to play again? ('yes' or 'no') CASE SENSITIVE");

            // holds the int of the users input to be returned
            Console.BackgroundColor = ConsoleColor.Black;
            string sInput = Console.ReadLine();

            // validate inputs 
            do
            {
                // check if input was a string, then check if it was within the allotted range
                if (String.Equals(sInput, "yes"))
                {
                    Console.WriteLine("Alright one sec as we get things ready for you!");
                    return true;
                }
                else if (String.Equals(sInput, "no"))
                {
                    Console.WriteLine("Alright thanks for playing!");
                    return false;
                }
                else
                {
                    // incriment incorrect input counter
                    nCntr++;

                    // set of responses for if the user keeps getting the inputs wrong
                    switch (nCntr)
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Input 'yes' OR 'no' CASE SENSITIVE");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("'yes' OR 'no'\nCASE SENSITIVE");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("was CASE SENSITIVE not obvious");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please I don't understand what you're typing");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(";-;");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("please, just 'yes' or 'no'\n...case sensitive");
                            Console.BackgroundColor = ConsoleColor.Black;
                            sInput = Console.ReadLine();
                            break;
                    }
                    bValid = false;
                }
            }
            while (!bValid);

            return false;
        }

        // Method: UserMadeStory
        // Purpose: Using a user's input, create a story made out of
        //              responses to prompts generated from the selected story
        //          Each story is held inside of the stories array, which the user first 
        //              selects out of; then the user is prompted for adjectives, nouns, etc.
        //          Each response is placed inside of a final output which is returned at the
        //              end and is prined out to the console
        // Parameters: stories {string[]} array of several stories to be selected from
        // Return: userStory {string} the final output of the user's inputs
        // Restrictions: none
        static string UserMadeStory(string[] stories)
        {
            // get the user's input
            Console.WriteLine("Pick a number between 1 - {0}", stories.Length);
            string sInput = Console.ReadLine();
            // validate the user's input and turn it into a int
            int nInput = ValidateInput(sInput, stories.Length);


            // create a array to store the user's selected story
            //   selected story is the user's input - 1 so that it fits the size of the array
            string[] story = stories[nInput - 1].Split(' ');

            // string that will hold the final story
            string userStory = "";

            for (int i = 0; i < story.Length; i++)
            {
                // if calling for user input, clean up the section and take the input
                if (story[i].StartsWith("{"))
                {
                    // take the needed input and replace "{" "}" and "_"
                    string sNeededInput = story[i].Replace("{", "").Replace("}", "").Replace(",", "").Replace(".", "").Replace("_", " ");
                    // prompt user for the needed MadLibs word
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Give me a {0}: ", sNeededInput);

                    // assign user's input to the story and add a space
                    //   if containing a special charcter, add that back in
                    if (story[i].Contains(","))
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        userStory += Console.ReadLine() + ", ";
                    }
                    else if (story[i].Contains("."))
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        userStory += Console.ReadLine() + ". ";
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        userStory += Console.ReadLine() + " ";
                    }

                }
                // if calling for a line break character, add the line break character
                else if (String.Equals(story[i], "\\n"))
                {
                    userStory += '\n';
                }
                // otherwise just add the next word and a space
                else
                {
                    userStory += story[i] + " ";
                }
            }

            return userStory;
        }

        // Method: Main
        // Purpose: Main function that opens when the program starts
        //          Runs a function that initializes the app, then continually
        //              creates user driven stories from inputs
        // Restriction: none
        static void Main(string[] args)
        {
            // states whether user is still playing
            bool bPlaying;

            // grab all the available stories using the InitializeStory Method
            string[] stories = InitializeStory();

            // do-while loop that runs once, then will run again
            //      so long as the user requests it 
            do
            {
                // create the users story with the CreateUserStory Method
                string userStory = UserMadeStory(stories);

                // finally write the story out
                Console.WriteLine(userStory);

                bPlaying = ValidateInput();
            } 
            while (bPlaying);
        }
    }
}
