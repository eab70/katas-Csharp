using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Numbers4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(
                "The items available for purchase in this vending machine are: popcorn, $1.25; peanuts, $2.00; Hershey kisses, $1.50; ice cream sandwich, $0.75; apple juice, $1.00.");

            Console.WriteLine("What is the price of the item you wish to purchase: ");
            decimal userInput = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The amount of money you inserted into the vending machine is: ");
            decimal userInput2 = decimal.Parse(Console.ReadLine());

            string[] change = ChangeCalc(userInput, userInput2);

            Console.WriteLine("Your change is {0} quarters, {1} dimes, {2} nickles and {3} pennies.", change[0],
                change[1], change[2], change[3]);
            Console.ReadLine();
        }

        public static string[] ChangeCalc(decimal a, decimal b)
        {
            string[] coins = new string[4];

            if (a > b)
            {
                Console.WriteLine("That is not enough money for the item.");
            }
            else
            {
                decimal c = b - a;
                decimal quarters;
                decimal dimes;
                decimal nickles;
                decimal pennies;

                if (c >= 0.25M)
                {
                    quarters = (c/25)*100;
                    decimal numOfQuarters = Math.Floor(quarters);
                    c = c - numOfQuarters*25/100;
                    string quarter2 = numOfQuarters.ToString("0");
                    coins[0] = quarter2;
                }

                if (c >= 0.10M)
                {
                    dimes = (c/10)*100;
                    decimal numOfDimes = Math.Floor(dimes);
                    c = c - numOfDimes*10/100;
                    string dimes2 = dimes.ToString("0");                    
                    coins[1] = dimes2;
                }

                if (c >= 0.05M)
                {
                    nickles = (c/5)*100;
                    decimal numOfNickles = Math.Floor(nickles);
                    c = c - numOfNickles*5/100;
                    string nickles2 = nickles.ToString("0");
                    coins[2] = nickles2;
                }

                if (c < 0.05M && c > 0)
                {
                    pennies = (c/1)*100;
                    decimal numOfPennies = Math.Floor(pennies);
                    string c2 = numOfPennies.ToString("0");
                    coins[3] = c2;
                }
            }
            return coins;
        }
    }
}





//Change Return Program
//Difficulty: 2

//Create a program where it shows the user a list of items to buy and their price. Then ask the user to pick an item and enter in the 
//amount of money they would have inserted into the “vending machine”. Have the program calculate the change and return it to the user in 
//the form of quarters, dimes, nickels and pennies. For example, if the user chooses an item that costs $1.25 and they say they give 
//it $2.07 the program would print out 3 quarters, 1 nickel and 2 pennies as change for the user.

//Tips
//-------------------------------
//First find out the difference between the item they bought and how much they are paying. Then look at using integer division to 
//first calculate how many coins of each type to return. Then use the modulus (% operator in most languages) to determine the remainder 
//of the change and repeat the process for each denomination. Be sure to check that the money they have inserted will first cover the price
//of the item! For example 89 cents / 25 is 3. This means 3 quarters with 14 cents returned.