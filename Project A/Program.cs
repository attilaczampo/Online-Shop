using Project_A;
using MyApp;
using System;

namespace ProjectA 
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeStruct E1 = new EmployeeStruct(10, "Kevin", "Developer");
            E1.ShowEmployeeStructData();

            EmployeeStruct E2 = new EmployeeStruct();
            E2.ShowEmployeeStructData();

            EmployeeStruct E3 = new EmployeeStruct
            {
                ID = 21,
                Name = "Andrea",
                Role = "HR"
            };
            E3.ShowEmployeeStructData();


            CustomerStruct C1 = new CustomerStruct();
            CustomerStruct C2 = new CustomerStruct();
            CustomerStruct C3 = new CustomerStruct();

            C1.getCustomerStructData("John", "johnarryn@mail.com", 1101);
            C2.getCustomerStructData("Alice", "aliceb32@gmail.com", 2453);
            C3.getCustomerStructData("Robb", "robb_af3@gmail.com", 304);

            C1.showCustomerStructData();
            C2.showCustomerStructData();
            C3.showCustomerStructData();
        }
    }
}