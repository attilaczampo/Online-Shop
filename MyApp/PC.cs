using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class PC : Products
    {
        public PC(string producer, string product, int year, string color):base(producer, product, year, color)
        {
        }
        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Details: ");
            Console.WriteLine("\t");
            Console.WriteLine("Address: " + "Piata Victoriei, 143B, Marasti, Cluj");
            Console.WriteLine("\t");
        }
        public override void OrderSummary()
        {
            Console.WriteLine("Order Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 1 ");
            Console.WriteLine("Total: 1899$ ");
            Console.WriteLine("\t");
            bool f = true;
            Console.WriteLine("Do you want to add guarantee for another 2 year?" + " " + f);
        }
        public override void Message()
        {
            Console.WriteLine("Thank you, for choosing us! You'll get an email about your order details!");
        }

     
    }
}
