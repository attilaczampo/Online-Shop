using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class TV: Details
    {
        public TV():base()
        {

        }
        public override void SetQuantity()
        {
            Console.WriteLine("Quantity: 3");
        }
        public override void GetPrice()
        {
            Console.WriteLine("Total: 3500$");
        }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("You will get an email about your command and shipping info.");
        }
    }
}
