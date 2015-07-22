using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labs_Challenges_WordReverse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence that will have its individual words reversed: ");
            string userInput = Console.ReadLine();

            var words = string.Join(" ",
                    userInput.Split(' ')
                    .Select(s => new String(s.Reverse().ToArray())));

            foreach (char word in words)
                Console.Write(word);

            Console.ReadLine();
        }
    }
}


//Given a string containing a sentence, reverse the characters of each word, but not the string itself.
//ex: "I am a human being" -> "I ma a namuh gnieb"
