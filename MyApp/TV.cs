using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class TV: Details
    {
        public TV(string company, string product, int year, string color) : base(company, product, year, color)
        {
        }
        public override void PaymentDetails()
        {
            Console.WriteLine("Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 1 ");
            Console.WriteLine("Total: 1499$ ");
        }

        public override void Message()
        {
            Console.WriteLine("You will get an email about your command and shipping info.");
        }

        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Address: ");
            Console.WriteLine("Piata Petru Maior, Nr 22, Marasti, Cluj;");
        }
    }
}
