using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsStrings2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a word or phrase: ");
            string userInput = Console.ReadLine().ToLower();

            int vowelCount = Vowels(userInput);
            int consCount = Consonents(userInput);
            int spaceCount = Space(userInput);
            Console.WriteLine("There are {0} vowel(s), {1} consonant(s) and {2} space(s) in that word/phrase.", vowelCount, consCount, spaceCount);
            Console.ReadLine();
        }

        public static int Vowels(string str)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            
            int countv = 0;
            
            
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    countv++;
                }
            }
            return countv;

        }

        public static int Consonents(string str)
        {
            char[] consonents =
            {
                'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v',
                'w', 'x', 'y', 'z'
            };
            
            int countc = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (consonents.Contains(str[i]))
                {
                    countc++;
                }
            }
            return countc;

        }

        public static int Space(string str)
        {
            string space = " ";

            int counts = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (space.Contains(str[i]))
                {
                    counts++;
                }
            }
            return counts;
        }
        }
    }




//Character Counting
//Difficulty: 2

//Make a program which asks the user to enter in a string and then prints out how many vowels are in that string. For example, the user enters “hello world” 
//and it returns “There are 3 vowels in ‘hello world’”.

//Tips
//-------------------------------
//Strings are typically thought of and used as an array of characters. If you can loop through these characters one by one, you can compare them to a list of vowels. 
//If you find one that matches, increment a counter variable. After the loop is done, the counter will then contain your count.

//Added Difficulty
//-------------------------------
//Count the consonants as well as spaces. Provide a mini report of all these counts.
