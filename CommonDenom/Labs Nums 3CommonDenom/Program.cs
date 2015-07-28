using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labs_Nums_3CommonDenom
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter the first of two fractions: ");
            string userInput = Console.ReadLine();
            Console.Write("Please enter the second fraction: ");
            string userInput2 = Console.ReadLine();
            
            int common = LargestCommonDenom(userInput, userInput2);
            int common2 = LeastCommonDenom(userInput, userInput2);
            Console.WriteLine("The least common denominator is: {0}, and the largest common denominator: {1}", common2,
                common);

            Console.ReadLine();
        }
        
        public static int LeastCommonDenom(string a, string b)
        {
            string[] a2 = a.Split('/');
            string a3 = a2[1];
            int a4 = int.Parse(a3);

            string[] b2 = b.Split('/');
            string b3 = b2[1];
            int b4 = int.Parse(b3);
            int a4b4 = a4*b4;
            

            for (int i = 2; i <a4b4; i++)
            {
                if (a4 %b4 == 0)
                {
                    return a4;
                }
                else if (b4%a4 == 0)
                {
                    return b4;
                }
                else if (a4%i == 0 && b4%i == 0)
                {
                    return i;
                }
                i++;
                
            }return a4b4;
        }


        public static int LargestCommonDenom(string a, string b)
        {
            string[] a2 = a.Split('/');
            string a3 = a2[1];
            int a4 = int.Parse(a3);

            string[] b2 = b.Split('/');
            string b3 = b2[1];
            int b4 = int.Parse(b3);

            int ab = a4*b4;
            return ab;
        }
    }
}

//However, fractions are not simplified in above.

//LCD/GCD Least/Greatest Common Denominator
//Create a program that asks the user to enter two fractions. Have the program find the least 
//common or the greatest common denominator between those two fractions and print it out.

