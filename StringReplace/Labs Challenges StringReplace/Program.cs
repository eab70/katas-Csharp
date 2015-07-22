using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Labs_Challenges_StringReplace
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word in which to replace some characters: ");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter the 1 or more adjacent letters you want to have replaced: ");
            string b = Console.ReadLine();
            Console.WriteLine("Please enter the equivalent number of letters to replace the removed letters: ");
            string c = Console.ReadLine();

            string replaceA = HardReplace(a, b, c);

            Console.WriteLine(replaceA);
            Console.ReadLine();
        }

        public static string HardReplace(string a, string b, string c)
        {
           
        int d = 0;

            if (a.Contains(b))
            {
                d = a.IndexOf((b));
            }

            int d2 = d + b.Length;

        string ahalf = a.Substring(0, d);
        string ahalf2 = a.Substring(d2);  
           
        return (ahalf + c + ahalf2);
            
        }
        
    }
}
//Many languages have a Replace() method on the string class.

//Without using your framework's built-in Replace method write a method to replace characters with other characters in a string.

//ex: given "apple", "pp", "dd" -> "addle"
//    given "Billy Joe Moe Bob", "oe", "" -> "Billy J M Bob"