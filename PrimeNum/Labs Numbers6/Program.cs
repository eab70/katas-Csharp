﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Numbers6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a number after which you want to find the next prime number: ");
            int userInput = int.Parse(Console.ReadLine());

            var prime = PrimeN(userInput);
            Console.WriteLine("The next prime number is {0}", prime);
            Console.ReadLine();
        }

        public static int PrimeN(int number)
        {
            while (true)
            {
                bool isPrime = true;
                number += 1;
                int sqNumber = (int) Math.Sqrt(number);

                for (int i = 2; i <= sqNumber; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    return number;
            }
        }
    }
}

     


//Next Prime Number
//Difficulty: 2

//Ask the user to enter a number and have the program find the next prime number after that value. If you don’t remember, a prime number is a number which can 
//only be divided by 1 and itself. Thus if the user enters 3, have the program find the next prime number (5) and print it out.

//Tips
//-------------------------------
//There are many ways to find primes. One of the simplest ways to find a prime is to simply start from the number the user enters
//and loop through the numbers one by one testing if it is prime. You can test if it is prime by trying to divide that number by all 
//numbers starting from 2 until the square root of that number. If none divide evenly, it is prime. For example, to test if 11 is prime, 
//we take the square root of it (which is a little over 3) and we test from 2 to 3. If none of them divide evenly 
//(test the remainder of the division) then it is prime. Since 2 nor 3 divide evenly into 11, it is prime. Test 12... 
//square root is again a little over 3 so we move from 2 to 3 and see if any divide evenly. Since 2 divides evenly into 12, it is not prime. 
//Look at the modulus operator to help you do this.

//Added Difficulty
//-------------------------------
//See if you can speed up this method by checking the last digit of the number. Obviously if the number ends in 2 it is even so it not 
//going to be prime (unless the number itself is 2).
