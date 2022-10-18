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
    public abstract class Details
    {
        //public Details()
        //{
        //    Console.WriteLine("Here are your order details:");
        //}

        string Company;
        string Product;
        int Year;
        string Color;
       

        public Details(string company, string product, int year, string color)
        {
            this.Company = company;
            this.Product = product;
            this.Year = year;
            this.Color = color;


            Console.WriteLine("Here are your order details:");
            Console.WriteLine("\t");
            Console.WriteLine("Product details: ");
            Console.WriteLine("\t");
            Console.WriteLine("Producer: " + Company);
            Console.WriteLine("Product: " + Product);
            Console.WriteLine("Product year: " + Year);
            Console.WriteLine("Product color: " + Color);
            Console.WriteLine("\t");
        }

        //public abstract void GetPrice();
        //public abstract void SetQuantity();

        public virtual void PaymentDetails()
        {
            Console.WriteLine("Summary: ");
            Console.WriteLine("\t");
            Console.WriteLine("Quantity: ");
            Console.WriteLine("Total: ");
        }
        public abstract void Message();

        public abstract void ShippingAddress();
        
    }
}
