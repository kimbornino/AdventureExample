using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureExample
{
    class CashRegister
    {
        //variables
        public string paymentType;

        public void AcceptCreditCard()
        {

            Console.WriteLine("Your credit card payment has been processed.");
        }

        public void AcceptCash()
        {
            Console.WriteLine("Your cash payment has been recieved.");
        }
    }
}
