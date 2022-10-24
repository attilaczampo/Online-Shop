using System;
using MyApp;

namespace ProjectB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("CONSTRUCTOR TYPES: ");

            // Default constructor

            DefaultConstructor constructor1 = new DefaultConstructor();
            constructor1.Vehicle = "BMW";
            constructor1.Model = "5 Series";
            constructor1.Year = 2014;

            Console.WriteLine("Your car is: " +constructor1.Vehicle + " "+constructor1.Model +" "+ constructor1.Year);

            // Parameterized constructor

            ParameterizedConstructor constructor2 = new ParameterizedConstructor("Rolex", "The best quality luxury watches", 300000);
            constructor2.PrintParamConstr();
        }
    }
}
