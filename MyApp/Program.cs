﻿using System;

namespace MyApp
{
    public class Program
    {
        int a;
        static void Main(string[] args)
        {
            Phone iPhone = new Phone("Apple Inc.", "IPhone 14 Pro", 2022, "Rose Gold");
            iPhone.ShippingAddress();
            iPhone.OrderSummary();
            iPhone.Message();
            
            Console.WriteLine("************************************************************");


            PC omen = new PC("HP", "HP Omen GamingLaptop", 2022, "Crimson Red");
            omen.ShippingAddress();
            omen.OrderSummary();
            omen.Message();
            
            Console.WriteLine("************************************************************");

            TV samsung = new TV("Samsung Inc.", "Samsung 3000Series", 2021, "Black");
            samsung.ShippingAddress();
            samsung.OrderSummary();
            samsung.Message();

            Console.WriteLine("************************************************************");

            // Constructor Types showcase:
            Console.WriteLine("CONSTRUCTOR TYPES: ");
            Console.WriteLine("\t");

            Phone Huawei = new Phone();  // Parameterless constr. in Phone.cs

            Console.WriteLine("\t");

            Watch Rolex = new Watch("Rolex", "Luxury,High quality watch", 20000);   // Parameterized const in Watch.cs

            Console.WriteLine("\t");

            Console.WriteLine("This is the default constructor!");

            Program p1 = new Program();          // Default constructor.
            Console.WriteLine("The value of 'a' is : " + p1.a);

            Console.WriteLine("\t");

            Console.WriteLine("This is the Copy Constructor :"); // Copy constructor in Watch.cs
            Console.WriteLine("\t");

            Watch Casio = new Watch("GOLD");
            Watch Casio2 = new Watch(Casio);


            // Private constructor here.
            // inaccessible due to its protection level

            // Watch a = new Watch();

            Console.WriteLine("\t");
            Console.WriteLine("This is the static constructor!");
            Console.WriteLine("\t");

            Food burger = new Food();
            Food pizza = new Food();
        }
    }
}
