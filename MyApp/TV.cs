using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class TV: Details
    {
        public TV(string producer, string product, int year, string color):base(producer, product, year, color)
        {

        }
        public override void OrderSummary()
        {
            Console.WriteLine("Order Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 2 ");
            Console.WriteLine("Total: 2999$ ");
        }

        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Details: ");
            Console.WriteLine("\t");
            Console.WriteLine("Address: Bulevardul Unirii, Nr. 108A, Bucuresti");
            Console.WriteLine("\t");
        }


        public override void Message()
        {
            Console.WriteLine("You will get an email about your command and shipping info.");
        }
      
    }
}
