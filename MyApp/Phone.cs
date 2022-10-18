using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Phone : Details
    {
        string Company;
        string Product;
        int Year;
        string Color;

        public Phone(string company, string product, int year, string color):base(company, product, year, color)
        {
        }

        //public void ShowInfo()
        //{
        //    Console.WriteLine("\t");
        //    Console.WriteLine("Product details: " + Company + " " + Product + " " + Year + " " + Color);
        //}

        //public Phone():base()
        //{
        //    Console.WriteLine("\t");
        //}
        //public override void SetQuantity()
        //{
        //    Console.WriteLine("Quantity: 4");
        //}
        //public override void GetPrice()
        //{
        //    Console.WriteLine("Total: 6500$");
        //}
        public override void PaymentDetails()
        {
            Console.WriteLine("Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 4 ");
            Console.WriteLine("Total: 4500$ ");
        }
        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Address: ");
            Console.WriteLine("Str.Victoriei, Nr 32, Manastur, Cluj;");
        }
        public override void Message()
        {
            Console.WriteLine("You will get an email about your command and shipping info.");
        }

    }
}
