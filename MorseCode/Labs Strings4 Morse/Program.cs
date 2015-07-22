using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Strings4_Morse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a word you wish converted to Morse code: ");
            string userInput = Console.ReadLine().ToUpper();

            Dictionary<string, string> mcode = new Dictionary<string, string>();
            mcode.Add("A", ". -");
            mcode.Add("B", "- . . .");
            mcode.Add("C", "- . - .");
            mcode.Add("D", "- . .");
            mcode.Add("E", ".");
            mcode.Add("F", ". . - .");
            mcode.Add("G", "- - .");
            mcode.Add("H", ". . . .");
            mcode.Add("I", ". .");
            mcode.Add("J", ". - - -");
            mcode.Add("K", "- . -");
            mcode.Add("L", ". - . .");
            mcode.Add("M", "- -");
            mcode.Add("N", "- .");
            mcode.Add("O", "- - -");
            mcode.Add("P", ". - - .");
            mcode.Add("Q", "- - . -");
            mcode.Add("R", ". - .");
            mcode.Add("S", ". . .");
            mcode.Add("T", "-");
            mcode.Add("U", ". . -");
            mcode.Add("V", ". . . -");
            mcode.Add("W", ". - -");
            mcode.Add("X", "- . . -");
            mcode.Add("Y", "- . - -");
            mcode.Add("Z", "- - . .");


            var decoded = new StringBuilder(userInput);

            foreach (var s in mcode)
                decoded.Replace(s.Key, s.Value);

            var result = decoded.ToString();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}


//Morse Code Maker
//Difficulty: 4
//Make a program which takes in a string from the user and then outputs that as a string of Morse Code. 
//If you are unfamiliar with Morse Code, you can find it on Wikipedia.
//Tips
//This is all about mapping a character to its Morse code equivalent. A string is seen as a list 
//of characters in C# so start by looping through these characters one by one and looking them up 
//in a table of characters you create. Map each character to a Morse Code character. 
//That way you can quickly identify which code goes with which letter and print it to screen. 
//Added Difficulty
//Translate the code generated back into the original text. This may require you to keep track of where spaces were also placed.
