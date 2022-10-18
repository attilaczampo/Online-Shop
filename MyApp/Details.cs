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
        public Details()
        {
            Console.WriteLine("Here are your order details:");
        }
        public abstract void GetPrice();
        public abstract void SetQuantity();
        public virtual void Message()
        {
            Console.WriteLine("Thank you for your order!");
        }

        public virtual void ShippingAddress()
        {
            Console.WriteLine("Piata Victoriei, 47A");
        }
    }
}
