using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Market market = new Market();
            CashRegister register = new CashRegister();
            Restaurant restaurant = new Restaurant();

            Console.WriteLine("Where would you like to eat?");
            string LunchChoice = Console.ReadLine();
            if (LunchChoice == "Market")
            {
                string sandwichChoice = market.SellSandwich();
                Console.WriteLine("you picked a " + sandwichChoice + "sandwhich ");

            }
            if (LunchChoice == "restaurant")
            {
                string foodChoice = restaurant.SellItem();
                Console.WriteLine("you picked a " + foodChoice);
            }

            Console.WriteLine("How would you like to pay?  Credit, or cash?");

            register.paymentType = Console.ReadLine();

            if (register.paymentType == "credit")
            {
                register.AcceptCreditCard();
            }
            if (register.paymentType == "cash")
            {
                register.AcceptCash();
            }

            Console.ReadKey();

        }
    }
    
}
