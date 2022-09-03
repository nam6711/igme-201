using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_6_ParsingAndFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates a random number generator Object
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            // TEST: prints the random number to the console
            //Console.WriteLine(randomNumber);

            // used for checking correct guesses
            bool bValid = false;
            // used to check if the player wants to play again
            bool bPlaying = true;
            // holds the user's guess
            string sGuess = null;
            int nGuess;

            // holds whether player will play again
            string sAgain = null;

            // while loop that runs as long as the player wants to play again
            while (bPlaying)
            {

                // prompt the user about the game
                Console.WriteLine("Guess a random number between 0 and 100! You have 8 tries to get it right!");

                // for loop that runs 8 times as long as the player hasn't guessed the randomNumber
                //   user has 8 tries to guess the random number
                for (byte i = 0; (i < 8 && !bValid); i++)
                {
                    // reset console background color
                    Console.BackgroundColor = ConsoleColor.Black;
                    // prompt the user with how many guesses they have left
                    Console.WriteLine("Guesses remaining: {0}", 8 - i);
                    // take the user's input
                    sGuess = Console.ReadLine();


                    // check the input's validity:
                    //   was the number a intiger?
                    //   was the number between 0-100?
                    // if not, prompt the user to try again

                    // checks for validity of input
                    while (!int.TryParse(sGuess, out nGuess))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number that is between 0-100: ");
                        // reset console background color
                        Console.BackgroundColor = ConsoleColor.Black;
                        sGuess = Console.ReadLine();
                    }
                    // checks for input being in the correct range
                    while (nGuess < 0 || nGuess > 100)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please input a valid number that is between 0-100: ");
                        // reset console background color
                        Console.BackgroundColor = ConsoleColor.Black;
                        sGuess = Console.ReadLine();
                        // check that new input is actually a valid input
                        while (!int.TryParse(sGuess, out nGuess))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please input a valid number that is between 0-100: ");
                            // reset console background color
                            Console.BackgroundColor = ConsoleColor.Black;
                            sGuess = Console.ReadLine();
                        }
                    }


                    // if player's guess is less than the real number
                    //   print it is too low

                    // else if the player's guess is higher than the real number
                    //   print it is too high

                    // else if the player's guess is correct
                    //   print that they won the game
                    if (nGuess < randomNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Your guess was too low!");
                    }
                    else if (nGuess > randomNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Your guess was too high!");
                    }
                    else if (nGuess == randomNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Congratulations! You guessed the number!!!");
                        bValid = true;
                        break;
                    }
                }

                //alert the player if they won or lost
                if (bValid)
                {
                    Console.WriteLine("Way to go!");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("So close! The correct answer was {0}", randomNumber);
                }

                // prompt the user if they want to play again
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Would you like ot play again?");
                // prompt player to play again
                sAgain = Console.ReadLine();

                //check if the player requested to play again

                if (sAgain.Trim().ToLower().StartsWith("y"))
                {
                    Console.WriteLine("Alright one sec as we set things up for ya!");

                    // reassign randomNumber value
                    randomNumber = rand.Next(0, 101);
                    // reset bValid to be false
                    bValid = false;
                } else
                {
                    // end game
                    bPlaying = false;
                }
            }
        }
    }
}
