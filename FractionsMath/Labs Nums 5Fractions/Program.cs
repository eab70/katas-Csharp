using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Nums_5Fractions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Do you wish to Add, Subtract, Multiply or Divide two fractions?\n" +
                              "Please enter, A, S M or D: ");
            string userInput = Console.ReadLine().ToUpper();

            string userInputa = "";
            do
            {
                Console.WriteLine("Please enter the first fraction (no zeros please): ");
                userInputa = Console.ReadLine();
                if (userInputa[2] == '0')
                {
                    Console.Write("Not a valid fraction.");
                }
            } while (userInputa[2] == '0');
            string a = userInputa;

            string userInputb = "";
            do
            {
                Console.WriteLine("Please enter the second fraction (no zeros please): ");
                userInputb = Console.ReadLine();
                if (userInputb[2] == '0')
                {
                    Console.Write("Not a valid fraction.");
                }
            } while (userInputb[2] == '0');
            string b = userInputb;
            
//Returned fractions not simplified.
            
            if (userInput == "A")
            {
                int newadd = Add(a, b);
                int newadd2 = LeastCommonDenom(a, b);
                if (newadd2 == 0)
                    Console.WriteLine("Undefined; there is a zero in the denominator.");
                else
                    Console.WriteLine("The answer is: {0} / {1}", newadd, newadd2);
            }

            if (userInput == "S")
            {
                int newsub = Sub(a, b);
                int newsub2 = LeastCommonDenom(a, b);
                if (newsub == 0)
                    Console.WriteLine("The answer is: 0");
                if (newsub2 == 0)
                    Console.WriteLine("Udefined; there is a zero in the denominator.");
               if (newsub >= 1 || newsub < 0)
                Console.WriteLine("The answer is: {0} / {1}", newsub, newsub2);
            }

            if (userInput == "M")
            {
                int[] newmulti = Multiply(a, b);
                if (newmulti[1] == 0)
                    Console.WriteLine("Undefined; i.e., there is a zero in the denominator.");
                else
                    Console.WriteLine("The answer is: {0} / {1}", newmulti[0], newmulti[1]);
            }

            else if (userInput == "D")
            {
                int[] newdiv = Divide(a, b);
                if (newdiv[1] == 0)
                    Console.WriteLine("Undefined; i.e., there is a zero in the denominator.");
                else
                    Console.WriteLine("The answer is: {0} / {1}", newdiv[0], newdiv[1]);
            }
            Console.ReadLine();
        }


        public static int[] StrAToInt(string a)
        {
            string[] a2 = a.Split('/');
            string a3 = a2[0];
            int a4 = int.Parse(a3);
            string a5 = a2[1];
            int a6 = int.Parse(a5);
            int[] newa = new int[2];
            newa[0] = a4;
            newa[1] = a6;
            return newa;
        }

        public static int[] StrBToInt(string b)
        {
            string[] b2 = b.Split('/');
            string b3 = b2[0];
            int b4 = int.Parse(b3);
            string b5 = b2[1];
            int b6 = int.Parse(b5);
            int[] newb = new int[2];
            newb[0] = b4;
            newb[1] = b6;
            return newb;
        }

        public static int[] Multiply(string a, string b)
        {
            int[] newera = StrAToInt(a);
            int[] newerb = StrBToInt(b);

            int abmult = newera[0]*newerb[0];
            int abmult2 = newera[1] * newerb[1];

            int[] multi = new int[2];
            multi[0] = abmult;
            multi[1] = abmult2;
            return multi;
        }


        public static int[] Divide(string a, string b)
        {
            int[] newera = StrAToInt(a);
            int[] newerb = StrBToInt(b);

            int abdiv = newera[0] * newerb[1];
            int abdiv2 = newera[1] * newerb[0];

            int[] div = new int[2];
            div[0] = abdiv;
            div[1] = abdiv2;
            
            return div;
        }

        public static int LeastCommonDenom(string a, string b)
        {
            string[] a2 = a.Split('/');
            string a3 = a2[1];
            int a4 = int.Parse(a3);

            string[] b2 = b.Split('/');
            string b3 = b2[1];
            int b4 = int.Parse(b3);
            int a4b4 = a4 * b4;


            for (int i = 2; i < a4b4; i++)
            {
                if (a4 % b4 == 0)
                {
                    return a4;
                }
                else if (b4 % a4 == 0)
                {
                    return b4;
                }
                else if (a4 % i == 0 && b4 % i == 0)
                {
                    return i;
                }
            }
            return a4b4;
        }


        public static int Add(string a, string b)
        {
            int[] newera = StrAToInt(a);
            int[] newerb = StrBToInt(b);

            int newerab = newera[1]*newerb[1];
            int newnume = (newera[0]*newerb[1]) + (newerb[0]*newera[1]);
            
            for (int i = 2; i < newerab; i++) 
            {
                if (newera[1] == newerb[1]) 
                {
                    int newnumd = newera[0] + newerb[0]; 
                    return newnumd;
                }

                if (newera[1]%newerb[1] == 0) 
                {
                    int newnuma = newerb[0]*(newera[1]/newerb[1]) + newera[0]; 
                    return newnuma;
                }
                if (newerb[1]%newera[1] == 0) 
                {
                    int newnumb = newera[0]*(newerb[1]/newera[1]) + newerb[0]; 
                    return newnumb;
                }
                if (newera[1]%i == 0 && newerb[1]%i == 0) 
                {
                    int newnumc = (newera[0]*i) + (newerb[0]*i);
                    return newnumc;
                }
            }
            return newnume;
        }

        
        public static int Sub(string a, string b)
        {
            int[] newera = StrAToInt(a);
            int[] newerb = StrBToInt(b);

            int newerab = newera[1] * newerb[1];
            int newnume = (newera[0] * newerb[1]) - (newerb[0] * newera[1]); 
            
            for (int i = 2; i < newerab; i++)
            {
                if (newera[1] == newerb[1]) 
                {
                    int newnumd = newera[0] - newerb[0];  
                    return newnumd;
                }

                if (newera[1]%newerb[1] == 0)  
                {
                    int newnuma = newera[0] - ((newera[1]/newerb[1]) *newerb[0]);   
                    return newnuma;
                }

                if (newerb[1] % newera[1] == 0)  
                {
                    int newnumb2 = (newera[0] *(newerb[1]/newera[1])) - newerb[0];  
                    return newnumb2;
                }

                if (newera[1] % i == 0 && newerb[1] % i == 0)  
                {
                    int newnumc = (newera[0]*i) - (newerb[0]*i);  
                    return newnumc;
                }
            }
            return newnume;
        }
    }
}


//Add/Subtract/Multiply/Divide Fractions
//Difficulty: 5

//This project involves working with fractions. How do you add 1/3 + 1/5? 
//Create a program that first asks the user which operation they want to do: add, subtract, 
//multiply or divide and then asks for 1, 2 or more fractions to work with. The program prints 
//out the result.
//Tips
//Think about how you might divide up the fraction itself into its numerator and denominator. Many of the operations involve finding a common denominator, getting its reciprocal and possibly reducing a fraction to lowest terms. This would be much easier if you can isolate the numerator from its denominator. You could also do this using a custom fraction class.

//Added Difficulty
//Try working with mixed, improper, or complex fractions.
