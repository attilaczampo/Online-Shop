using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone iPhone = new Phone("Apple Inc.", "IPhone 14 Pro", 2022, "Rose Gold");
            //iPhone.ShowInfo();
            //iPhone.SetQuantity();
            //iPhone.GetPrice();
            iPhone.ShippingAddress();
            Console.WriteLine("\t");
            iPhone.PaymentDetails();
            Console.WriteLine("\t");
            iPhone.Message();
            Console.WriteLine("\t"); // new line in cmd
            Console.WriteLine("************************************************************");


            PC omen = new PC("HP Inc.", "HP-Omen Gaming", 2022, "Crimson Red");
            //omen.SetQuantity();
            //omen.GetPrice();
            omen.ShippingAddress();
            Console.WriteLine("\t");
            omen.PaymentDetails();
            Console.WriteLine("\t");
            omen.Message();
            Console.WriteLine("\t");
            Console.WriteLine("************************************************************");

            TV samsung = new TV("Samsung Corporation", "Samsung 3000Series", 2021, "Black");
            samsung.ShippingAddress();
            Console.WriteLine("\t");
            samsung.PaymentDetails();
            Console.WriteLine("\t");
            samsung.Message();
            Console.WriteLine("\t");
            Console.WriteLine("************************************************************");

        }
    }
}
