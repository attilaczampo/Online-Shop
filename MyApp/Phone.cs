using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Phone : Details
    {
        public Phone():base()
        {

        }
        public Phone(string producer, string product, int year, string color) :base(producer, product, year, color )
        { 

        }
        public override void OrderSummary()
        {
            Console.WriteLine("Order Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 5 ");
            Console.WriteLine("Total: 7000$");
        }

        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Details: ");
            Console.WriteLine("\t");
            Console.WriteLine("Address: " + "Str.Victoriei, Nr 32, Manastur, Cluj;");
            Console.WriteLine("\t");
        }
        public override void Message()
        {
            Console.WriteLine("You will get an email about your command and shipping info.");
        }

    }
}
