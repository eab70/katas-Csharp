using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Numbers5
{
    class Program
    {

        static void Main()
        {
            Console.Write("Please enter the Nth value you seek in the Fibonacci sequence: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadLine();
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        
    }
}


//Fibonacci Sequence
//Difficulty: 2

//Create a program that calculates the Fibonacci sequence up to the Nth term. Ask the user to enter the Nth term and have the program 
//calculate the sequence until it has printed that many terms.

