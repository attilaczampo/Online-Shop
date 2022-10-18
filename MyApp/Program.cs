using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone iPhone = new Phone();
            iPhone.Manufacturer = "Apple Inc.";
            iPhone.Name = "IPhone 14 Pro";
            Console.WriteLine(iPhone.Manufacturer);
            Console.WriteLine(iPhone.Name);
            iPhone.SetQuantity();
            iPhone.GetPrice();
            iPhone.Message();
            iPhone.ShippingAddress();
            Console.WriteLine("********************");


            PC omen = new PC();
            omen.Manufacturer = "HP";
            omen.Name = "HP Omen GamingLaptop";
            Console.WriteLine(omen.Manufacturer);
            Console.WriteLine(omen.Name);
            omen.SetQuantity();
            omen.GetPrice();
            omen.Message();
            omen.Question();
            omen.ShippingAddress();
            Console.WriteLine("********************");

            TV samsung = new TV();
            
            samsung.Manufacturer = "Samsung";
            samsung.Name = "Samsung 3000 Series";
            Console.WriteLine(samsung.Manufacturer);
            Console.WriteLine(samsung.Name);
            samsung.SetQuantity();
            samsung.GetPrice();
            samsung.Message();
        }
    }
}
