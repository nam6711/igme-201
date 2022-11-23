using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    internal class Program
    {
        /* Method - PrintQuestion
         * 
         * Author - Nat Manoucheri
         * 
         * Purpose - prints out the question and all possible
         *           answer options
         * 
         * Paramaters - Trivia q holds the trivia question data
         * 
         * returns int correctNum - this is the number to check if the user inputted as
         *                          this number was what was randomly chosen to be the correct
         *                          answer
         */
        static int PrintQuestion(Trivia q)
        {
            // print question
            Console.WriteLine(q.results[0].question);
            // pick a random number for the question answer to be (between 0 and 3)
            Random random = new Random();
            int correctNum = random.Next(0, 4);

            // count the number of incorrect answers that have been printed
            int nWrongAnsPrinted = 0;

            // print answer options and keep track of how many answers have
            //   been printed
            for (int i = 0; i < 4; ++i)
            {
                if (i == correctNum)
                {
                    // print the write answer
                    Console.WriteLine($"{i + 1}. - {q.results[0].correct_answer}");
                } 
                else
                {
                    // print an incorrect answer
                    Console.WriteLine($"{i + 1}. - {q.results[0].incorrect_answers[nWrongAnsPrinted]}");
                    ++nWrongAnsPrinted;
                }
            }

            // return the number that the correct answer is
            //   in a format similar to what the user expects (options being 1 - 4)
            return (correctNum + 1);
        }

        /* Method - PrintQuestion
         * 
         * Author - Nat Manoucheri
         * 
         * Purpose - gets and validates the users answer, and checks if it is correct
         * 
         * Paramaters - Trivia q holds the trivia question data
         *              int correctNum holds the number answer that was correct
         */
        static void CheckAnswer (Trivia q, int correctNum)
        {
            // prompt user for input
            int answer = -1;
            string input = null;
            // validate answer
            do
            {
                Console.WriteLine("Pick an answer between 1 and 4!");
                input = Console.ReadLine();
            } while (int.TryParse(input, out answer) && answer < 1 && answer > 4);

            // Check if user was right
            if (answer == correctNum)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Sorry, the answer was {correctNum} - {q.results[0].correct_answer}");
            }
        }

        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            // print question and then check the user's answer
            CheckAnswer(trivia, PrintQuestion(trivia));
        }
    }
}
