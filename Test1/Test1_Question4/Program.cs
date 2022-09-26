using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace Test1_Question4
{

    static internal class Program
    {
        // variable to hold the timer
        static Timer timer;

        // delegate to hold which question was asked
        delegate bool Question( ref bool bInTimer, ref Timer timer, ref string answer );

        static void Main(string[] args)
        {
            // create and store which question is beeing asked
            Question q;

            // Hold input for which question to ask
            string sQuestion;
            int nQuestion;

            //hold whether the user was right
            bool bCorrect;
            // holds whether the player was in time
            bool bInTime;
            // holds the correct answer
            string answer = "";

            start:
            // init nQuestion as 0
            nQuestion = 0;

            // Ask which questions (check to make sure it is within 1-3)
            //   validate their answer to make sure it exists
            do {
                Console.Write("Choose your question (1-3): ");
                sQuestion = Console.ReadLine();

                // tryParse the stirng to an int
                int.TryParse( sQuestion, out nQuestion);
            } while (nQuestion <= 0 || nQuestion > 3);

            // decide which question based upon what their input was
            switch (nQuestion)
            {
                case 1:
                    q = new Question(Question1);
                    break;
                case 2:
                    q = new Question(Question2);
                    break;
                case 3:
                    q = new Question(Question3);
                    break;
                default:
                    q = new Question(Question1);
                    break;
            }

            //start bInTime as true every time
            bInTime = true;
            //init timer
            timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler((object sender, ElapsedEventArgs e) => {
                bInTime = false;
                Console.WriteLine("Time's up!");
                Console.WriteLine($"The answer is: {answer}");
                Console.WriteLine("Please press enter");
                timer.Stop();
            });

            // Display the proper Question
            //  returns whether the user was right
            bCorrect = q(ref bInTime, ref timer, ref answer);

            // check if they answered in time and were correct
            if (bCorrect && bInTime)
            {
                Console.WriteLine("Well Done!");
            }
            else if (!bCorrect && bInTime)
            {
                Console.WriteLine($"The answer is: {answer}");
            }

            // ask to play again
            Console.Write("Play Again? ");
            if (string.Equals(Console.ReadLine().Trim().ToLower().Substring(0, 1), "y"))
            {
                goto start;
            }
        }

        static bool Question1(ref bool bInTimer, ref Timer timer, ref string answer)
        {
            // initialize a variable to hold the input
            string sInput;
            //set the value of the answer
            answer = "black";

            // print instructions then the question
            Console.WriteLine("You have 5 seconds to answer the following question: ");
            Console.WriteLine("What is your favorite color?");

            // start the timer
            timer.Start();

            // take user input
            sInput = Console.ReadLine();

            // stop the timer
            timer.Stop();

            // check if user was correct
            //      return whether they were or weren't
            if (string.Equals(sInput.ToLower(), answer))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        static bool Question2(ref bool bInTimer, ref Timer timer, ref string answer)
        {
            // initialize a variable to hold the input
            string sInput;
            //set the value of the answer
            answer = "42";

            // print instructions then the question
            Console.WriteLine("You have 5 seconds to answer the following question: ");
            Console.WriteLine("What is the answer to life, the universe and everything ?");

            // start the timer
            timer.Start();

            // take user input
            sInput = Console.ReadLine();

            // stop the timer
            timer.Stop();

            // check if user was correct
            //      return whether they were or weren't
            if (string.Equals(sInput.ToLower(), answer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Question3(ref bool bInTimer, ref Timer timer, ref string answer)
        {
            // initialize a variable to hold the input
            string sInput;
            //set the value of the answer
            answer = "What do you mean? African or European swallow?";

            // print instructions then the question
            Console.WriteLine("You have 5 seconds to answer the following question: ");
            Console.WriteLine("What is the airspeed velocity of an unladen swallow?");

            // start the timer
            timer.Start();

            // take user input
            sInput = Console.ReadLine();

            // stop the timer
            timer.Stop();

            // check if user was correct
            //      return whether they were or weren't
            if (string.Equals(sInput.ToLower(), answer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
