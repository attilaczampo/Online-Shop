using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class CopyConstructor
    {
        string Vehicle, Color;
        int Year;

        public CopyConstructor(string vehicle, string color, int year)
        {
            Vehicle = vehicle;
            Color = color;
            Year = year;

            Console.WriteLine("COPY CONSTRUCTOR");
            Console.WriteLine("\t");
            Console.WriteLine("The first car info: " + vehicle + " " + color + " " + year);
        }

        public CopyConstructor(CopyConstructor car)
        {
            Vehicle = car.Vehicle;
            Color = car.Color;
            Year = car.Year;

            Console.WriteLine("The second car info: " + car.Vehicle + " " + car.Color + " " + car.Year);
        }
    }
}
