using System;
using MyApp;

namespace ProjectB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONSTRUCTOR TYPES: ");

            // Default constructor

            DefaultConstructor student = new DefaultConstructor();
            student.PrintDefConstr();
            Console.WriteLine("Student Id is: " + student.Id);
            Console.WriteLine("Student Name is: " + student.Name);
            Console.WriteLine("Student Age is: " + student.Age);
            Console.WriteLine("Student Address is: " + student.Address);
            Console.WriteLine("Is the student on holiday? " + student.isOnHoliday);
            Console.WriteLine("\t");

            // Parameterized constructor

            ParameterizedConstructor watch = new ParameterizedConstructor("Rolex", "The best quality luxury watches", 300000);
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR");
            watch.PrintParamConstr();

            // Copy constructor

            CopyConstructor car1 = new CopyConstructor("BMW", "Blue", 2016);

            CopyConstructor car2 = new CopyConstructor(car1);

            // Private constructor

            //PrivateConstructor p1 = new PrivateConstructor();
            //p1.Name ="Private constructor."

            // Compiler error: we cannot acces the constructor due its protection level.


            // Static constructor
            var x = StaticConstructor.interestRate;
            Console.WriteLine("\t");
            Console.WriteLine("STATIC CONSTRUCTOR");
            Console.WriteLine("\t");

            StaticConstructor loantaker1 = new StaticConstructor("John", 308);
            loantaker1.PrintStaticConstr();

            StaticConstructor loantaker2 = new StaticConstructor("Andrea", 98);
            loantaker2.PrintStaticConstr();

            // Static constructor NO.2

            StaticConstructor2 SC1 = new StaticConstructor2();
            StaticConstructor2 SC2 = new StaticConstructor2();
            



        }
    }
}
