using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class PC : Details
    {

        public PC (string company, string product, int year, string color) : base(company, product, year, color)
        {
        }
        //public PC():base()
        //{
        //    Console.WriteLine("\t");
        //}
        //public override void SetQuantity()
        //{
        //    Console.WriteLine("Quantity: 1");
        //}
        //public override void GetPrice()
        //{
        //    Console.WriteLine("Total: 1800$");
        //}
     
        public override void PaymentDetails()
        {
            Console.WriteLine("Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: 1 ");
            Console.WriteLine("Total: 1699$ ");
        }
        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Address: ");
            Console.WriteLine("Bulevardul Unirii, 89B, Bucuresti;");
        }

        public override void Message()
        {
            bool f = true;
            Console.WriteLine("Do you want to add guarantee for another 2 year for just 199$ ?" + " " + f);
            Console.WriteLine("Thank you for choosing us! We will send you an email about the your order and shipping details.");
        }


    }
}
