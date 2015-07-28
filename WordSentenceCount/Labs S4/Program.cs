using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labs_S4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a paragraph: ");
            string userInput = Console.ReadLine();

            int wordC = WordCount(userInput);
            int sentC = SentCount(userInput);
            Console.WriteLine("This sentence has {0} words in it and this paragraph has {1} sentences in it.", wordC, sentC);
            Console.ReadLine();


        }

        public static int WordCount(string str)
        {
            int countW = 0;
            string[] str3 = str.Split(' ');
            
            foreach (string word in str3)
            {
                countW++;
            }
            return countW;
        }

        public static int SentCount(string sent)
        {
            int countS = 0;
            string[] str4 = sent.Split('.');

            foreach (string word in str4)
            {
                countS++;
            }
            return countS;
        }
    }
}

//Word Counting

//Write a program which asks the user for a string and then counts how many words are in that string. For example if they write “This is my first program” the program would print out “There are 5 words”.
