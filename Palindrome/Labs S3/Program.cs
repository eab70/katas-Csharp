using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labs_S3
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Please enter a word to check:  ");
            string userInput = Console.ReadLine();

            bool palCk = PalindromeCk(userInput);

            if (palCk)
                Console.WriteLine("The string '{0}' is a palindrome.", userInput);
            else
            {
                Console.WriteLine("'{0}' is not a palindrome.", userInput);
            }
            Console.ReadLine();

        }

        public static bool PalindromeCk(string str)
        {
            
            string resultb = "";
            
            string newWord = str.Replace(" ", "");

            
            for (int i = newWord.Length - 1; i >= 0; i--)
            {
                resultb += newWord[i];
            }

            if (resultb.ToUpper() == newWord.ToUpper())
            {
                return true;  
            }
            else
                return false;
            

            
        }
    }
}



//Check If Palindrome

//A palindrome is a string of characters when read from left to right and right to left is exactly the same (ignoring any spaces usually). One of the most well
//known palindromes is “race car”. No matter which direction you read it, it still reads “race car”. Create a program which checks if a string entered is a palindrome. 
//If it is, print “The string ‘_____’ is a palindrome” where the blank is the string they entered.


