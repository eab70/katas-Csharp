using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Would you like to convert temperature or currency? ");
            string userInput = Console.ReadLine().ToUpper();

            if (userInput == "TEMPERATURE")
            {
                Console.Write(
                    "Please enter C if you'd like to convert Celsius to Fahrenheit or F if you'd like to convert Fahrenheit to Celsius: ");
                string userInput1 = Console.ReadLine().ToUpper();

                if (userInput1 == "C")
                {
                    Console.Write("Please enter the Celsius temperature: ");
                    string userInput2 = Console.ReadLine().ToUpper();
                    int input = int.Parse(userInput2);
                    int convert2 = TempConverter(input);
                    Console.WriteLine("The Fahrenheit equivalent is {0}", convert2);
                    Console.ReadLine();
                }
                else if (userInput1 == "F")
                {
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    string userInput3 = Console.ReadLine();
                    int input2 = int.Parse(userInput3);
                    int convert3 = TempConvert2(input2);
                    Console.WriteLine("The Celsius equivalent is {0}", convert3);
                    Console.ReadLine();
                }
            }
            else if (userInput == "CURRENCY")
                Console.Write(
                    "Please enter P if you'd like to convert pounds sterling to US dollars or D if you'd like to convert US dollars to pounds sterling: ");
            string userInput4 = Console.ReadLine().ToUpper();

            if (userInput4 == "P")
            {
                Console.Write("Please enter the pounds sterling amount to convert to dollars: ");
                string userInput5 = Console.ReadLine().ToUpper();
                decimal input3 = decimal.Parse(userInput5);
                decimal convert4 = CurrencyConverter(input3);
                Console.WriteLine("The US dollar equivalent is {0}", convert4);
                Console.ReadLine();
            }
            else if (userInput4 == "D")
            {
                Console.Write("Please enter the US dollars to convert to pounds sterling: ");
                string userInput6 = Console.ReadLine();
                decimal input4 = decimal.Parse(userInput6);
                decimal convert5 = CurrencyConvert2(input4);
                Console.WriteLine("The pounds sterling equivalent is {0}", convert5);
                Console.ReadLine();
            }
        }


        public static int TempConverter(int userInputa)
        {
            int convert = (userInputa*9/5) + 32;
            return convert;
        }

        public static int TempConvert2(int userInputb)
        {
            int convert2 = (userInputb - 32)*5/9;
            return convert2;
        }

        public static decimal CurrencyConverter(decimal userInputc)
        {
            decimal convert4 = userInputc*1.55m;
            return convert4;
        }

        public static decimal CurrencyConvert2(decimal userInputd)
        {
            decimal convert5 = userInputd *.64m;
            return convert5;

        }
    }
}


//Unit Converter
//Difficulty 2

//Develop a simple program which asks the user to first pick a conversion type (temperature, currency,
//volume, mass or some other unit type) and then asks the user for the unit of measure to convert from 
//and to convert it to. Lastly, ask the user to enter in a value which the program then converts to the 
//target unit. For instance, the user specifies temperature and then specifies Celsius to Kelvins. 
//They then enter in a value for Celsius and the program converts it to Kelvins and prints the result.

//Added Difficulty
//-------------------------------
//Allow the user to specify significant digits for the output.
