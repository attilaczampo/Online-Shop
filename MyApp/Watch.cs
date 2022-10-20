using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Watch
    {
        string Name;
        string Description;
        int Price;
        string Color;
        
        // In Watch.cs is a CONSTRUCTOR OVERLOADING. 
        // CONSTRUCTOR OVERLOADING = We can create TWO or MORE constructors in a class.

        public Watch(string name, string description, int price)      // Parameterized constr.
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;

            Console.WriteLine("This is a parameterized constructor!");
            Console.WriteLine("\t");
            Console.WriteLine("Name: " + name + "; " + "Description: " + description + "; " + "Price: " + price);
        }

        public Watch(string color)              
        {
            this.Color = color;

            Console.WriteLine("The color of the FIRST watch is " + color );
        }

        public Watch(Watch w1)              // Copy constr.
        {
            this.Color = w1.Color;

            Console.WriteLine("The color of the SECOND watch is " + w1.Color);
        }

        private Watch()
        {
            Console.WriteLine("This is the private constructor!");
        }
      
    }
}
