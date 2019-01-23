using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureExample
{
    class Restaurant
    {
        //variable
        public int foodItem;

        public string SellItem()
        {
            Console.WriteLine("What kind of sandwich would you like?  Type '1' for pizza, '2' for burger, '3' for spam.");
            foodItem = Convert.ToInt32(Console.ReadLine());

            switch (foodItem)
            {
                case 1:
                    Console.WriteLine("I think I better get TWO person sized...");
                    return "pizza";
                case 2:
                    Console.WriteLine("I'd prefer this medium rare!");
                    return "burger";
                case 3:
                    Console.WriteLine("I could write a whole play about YOU spam.");
                    return "spam";
                default:
                    Console.WriteLine("please try again");
                    SellItem();
                    return null;

            }
        }
    }
}
