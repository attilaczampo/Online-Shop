using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Food
    {
        static Food()
        {
            Console.WriteLine("This Food is STATIC");
        }

        public Food()
        {
            Console.WriteLine("This Food is Non-Static");
        }
    }
}
