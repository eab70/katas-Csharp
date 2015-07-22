using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnspliceKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please enter a combination of letters and \\ and \n: ");
            string str = Console.ReadLine();

            string rS = RemoveSlash(str);
            Console.WriteLine(rS);
            Console.ReadLine();
        }

        public static string RemoveSlash(string str)
        {
            int str1 = str.IndexOf(@"\\");
            int str2 = str.IndexOf(@"\n");
            string str3 = str.Replace("\\", "");
            //string str4 = str3.Replace("\n", "");
            string str5 = str3.Replace("n", "");
                        
            if (str1 +2 == str2)
            {                
            return str5;
            }

            else
                return str;                
        }

    }
}

//Given a string, strip all occurences of consecutively occuring backslash and newline characters. For example, 
//assuming that:  //"\\" represents '\' and //"\n" represents '\n'

//  "ab\\\ncd\\\nef" --> "abcdef" (two stripped out)

//  "abc\\\ndef"     --> "abcdef" (one stripped out)

//  "abc\n\\def"     --> unchanged (wrong order)

//  "abc\\def"       --> unchanged (no \n)

//  "abc\ndef"       --> unchanged (no \)

//  "abcdef"         --> unchanged

