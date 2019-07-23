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
            string vowels = "AEIOUaeio";
            foreach (string word in sentence.Split())
            {
                string y = "y";
                
                string firstLetterOfWord = sentence.Substring(0, 1);//starts at 0, moves up 1 letter
                string restOfTheWord = sentence.Substring(1, sentence.Length - 1);//is at moved up, letter
                //sentence.length goes through rest of word, -1 subtracts 1st letter, not touching current index
                int currentLetterOfWord = vowels.IndexOf(firstLetterOfWord);

                if (currentLetterOfWord == -1 && y == "y")
                {
                    sentence += restOfTheWord + firstLetterOfWord + "ay";

                }
                else
                {
                    sentence = word + "way";
                }

            }
            return sentence;

        }

    }
}

