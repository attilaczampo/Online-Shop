using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
            list.Add(new Phone("Apple Inc.", "IPhone 14 Pro", 2022, "Rose Gold"));
            list.Add(new PC("HP", "HP Omen GamingLaptop", 2022, "Crimson Red"));
            list.Add(new TV("Samsung Inc.", "Samsung 3000Series", 2021, "Black"));


            foreach (Products item in list)
            {
                item.OrderSummary();
                item.ShippingAddress();
                item.Message();
     
            }
            
        }
    }
}
