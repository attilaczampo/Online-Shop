using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public struct Customer
    {
        public string Name;
        public string EmailAddress;
        public int Id;
       
        public void getData(string name, string email, int id)
        {
            this.Name = name;
            this.EmailAddress = email;
            this.Id = id;
        }

        public void showData()
        {
            Console.WriteLine("CUSTOMER DETAILS:");
            Console.WriteLine("\t");
            Console.WriteLine("Customer_Name: {0}", this.Name);         // {0} - placeholder
            Console.WriteLine("Customer_EmailAddress: {0}", this.EmailAddress);
            Console.WriteLine("Customer_ID: {0}", this.Id);
        }
    }
}
