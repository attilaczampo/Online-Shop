using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone iPhone = new Phone("Apple Inc.", "IPhone 14 Pro", 2022, "Rose Gold");
            iPhone.ShippingAddress();
            iPhone.OrderSummary();
            iPhone.Message();

            Phone Huawei = new Phone();  // Parameterless constr. in Phone.cs

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
        }
    }
}
