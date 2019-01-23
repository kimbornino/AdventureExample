using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureExample
{
    class Market
    {
        //member variables
        public string sandwich;

        public string SellSandwich()
        {
            Console.WriteLine("What kind of sandwich would you like?  Type '1' for turkey, '2' for salami, '3' for spam.");
            int sandwich = Convert.ToInt32(Console.ReadLine());

            switch (sandwich)
            {
                case 1:
                    Console.WriteLine("Turkey again?");
                    return "turkey";
                case 2:
                    Console.WriteLine("Who doesn't love a good salami sammy?");
                    return "salami";
                case 3:
                    Console.WriteLine("I could write a whole play about YOU spam.");
                    return "spam";
                default:
                    Console.WriteLine("please try again");
                    SellSandwich();
                    return null;
            }
        }
    }
}
