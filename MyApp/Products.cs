using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    // ABSTRACT

    //The ABSTRACT modifier can be used wtih: CLASSES, METHODS, PROPERTIES, INDEXERS and EVENTS.

    //Use the ABSTRACT modifier in a class declaration to indicate that a class is intended only
    //to be a BASE CLASS of other CLASSES, not instantiated on its own.

    //MEMBERS marked as ABSTRACT must be implemented by NON-ABSTRACT CLASSES that derive from the ABSTRACT CLASS.
    public abstract class Products
    {
        string Producer;
        string Product;
        int Year;
        string color;

        public Products()
        {
            Console.WriteLine("This is a parameterless constructor!");
        }
        public Products(string producer, string product, int year, string color)
        {
            this.Producer = producer;
            this.Product = product;
            this.Year = year;
            this.color = color;

            Console.WriteLine("Here are your order details:");
            Console.WriteLine("\t");
            Console.WriteLine("Producer: " + producer);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Product Year: " + year);
            Console.WriteLine("Product Color: " + color);
            Console.WriteLine("\t");
        }

        public virtual void OrderSummary()
        {
            Console.WriteLine("Order Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: ");
            Console.WriteLine("Total: ");
        }
        public abstract void Message();
        public abstract void ShippingAddress();
        
    }
}
