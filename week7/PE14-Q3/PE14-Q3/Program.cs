using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Q3
{

    public interface IEncryptSetup
    {
        string Encrypt(string originalVal);
    }

    public class PigLatin : IEncryptSetup
    {
        public string Encrypt(string originalVal)
        {
            // turn param into a array of words
            string[] words = originalVal.ToLower().Trim().Split(' ');
            // string that holds all possible vowels
            string vowels = "aeiouAEIOU";
            // create a variable to hold the new string
            string converted = "";

            // iterate through all words in the array
            for (int i = 0; i < words.Length; i++)
            {
                // check if word starts with vowel by checking if the first letter
                //  is inside of the vowels string
                if (vowels.IndexOf(words[i][0]) >= 0)
                {
                    converted += words[i] + "way ";
                } 
                // check if first letter is a consonant and second letter is a vowel
                else if (vowels.IndexOf(words[i][0]) == -1 && vowels.IndexOf(originalVal[1]) >= 0)
                {
                    converted += words[i] + "ay ";
                }
                // check if first two letters are consonants
                else if (vowels.IndexOf(words[i][0]) == -1 && vowels.IndexOf(originalVal[1]) == -1)
                {
                    converted += words[i].Remove(0, 2) + "-" + words[i][0] + words[i][1] + "ay";
                }
            }
            return converted;
        }
    }

    public class AddRandom : IEncryptSetup
    {
        public string Encrypt(string originalValue)
        {
            // holds the random number generator
            Random random = new Random();
            // holds all indexes of the given string that have been selected
            int[] indexes = new int[originalValue.Length];
            // holds the current random number being selected
            int randomIndex;
            // holds the new string
            string newString = "";

            for (int i = 0; i < originalValue.Length; i++)
            {
                // pick a NEW random letter to add to the new string
                do
                {
                    randomIndex = random.Next(1, originalValue.Length + 1);
                } while (indexes.Contains(randomIndex));
                // add the new index to the array of indexes 
                indexes[i] = randomIndex;
                // add the randomly selected character
                newString += originalValue[randomIndex - 1];
            }

            return newString;
        }
    }

    internal class Program
    {
        public static void MyMethod(IEncryptSetup myObject)
        { 
            Console.WriteLine(myObject.Encrypt("test of scrambler, with a half-done pig latin and fully complete word scrambler"));
        }

        static void Main(string[] args)
        {
            PigLatin pigConvert = new PigLatin();
            AddRandom randomConvert = new AddRandom();

            MyMethod(pigConvert);
            MyMethod(randomConvert);
        }
    }
}
