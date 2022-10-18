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
        public override void SetQuantity()
        {
            Console.WriteLine("Quantity: 4");
        }
        public override void GetPrice()
        {
            Console.WriteLine("Total: 6500$");
        }

        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Address: Str.Victoriei, Nr 32, Manastur, Cluj;");
        }
        public override void Message()
        {
            base.Message();
            Console.WriteLine("You will get an email about your command and shipping info.");
        }

    }
}
