using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                /* method*/
                Console.WriteLine("Please enter a word.\n");
                string sentence = Console.ReadLine();
                string pigLatin = PigLatinTranslation(sentence);
                Console.WriteLine($"\n{pigLatin}\n");

                Console.WriteLine("\nWould you like to go again?\n");
                string input = Console.ReadLine();
                if (input != "y")
                {
                    Console.WriteLine("\nSee you later.");
                    cont = false;
                }
                else
                {
                    cont = true;
                }
            }

            Console.ReadKey();
            //for each (string x in (array))
        }

        public static string PigLatinTranslation(string sentence)
        {
            string[] array = sentence.Split(' '); //?
            char [] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string newSentence = "";
            foreach (string word in array) //definition?
            {
                
                string y = "y";

                int currentLetterOfWord = word.IndexOfAny(vowels); //going through character array and establishing an index of that first vowel.
                string firstLetterOfWord = word.Substring(0, currentLetterOfWord);//starts at 0, moves up 1 letter
                string restOfTheWord = word.Substring(1, word.Length - 1);//is at moved up, letter
                //sentence.length goes through rest of word, -1 subtracts 1st letter, not touching current index
                

                if (currentLetterOfWord == -1 && y == "y")
                {
                    newSentence = newSentence + restOfTheWord + firstLetterOfWord + "ay ";

                }
                else
                {
                    newSentence = newSentence + word + "way ";
                }

            }
            return newSentence;

        }

    }
}

//