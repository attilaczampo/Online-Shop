using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class PC : Details
    {
        public PC():base()
        {

        }
        public override void SetQuantity()
        {
            Console.WriteLine("Quantity: 1");
        }
        public override void GetPrice()
        {
            Console.WriteLine("Total: 1800$");
        }
        public void Question()
        {
            bool f = true;
            Console.WriteLine("Do you want to add guarantee for another 2 year?" + f);
        }
        
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public override void ShippingAddress()
        {
            Console.WriteLine("Shipping Address: Bulevardul Unirii, 89B, Bucuresti;");
        }

     
    }
}
