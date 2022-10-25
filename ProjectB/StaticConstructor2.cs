using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class StaticConstructor2
    {
        static StaticConstructor2()
        {
            Console.WriteLine("\t");
            Console.WriteLine("This is the STATIC CONSTRUCTOR");
        }
        public StaticConstructor2()
        {
            Console.WriteLine("This is the NON-STATIC CONSTRUCTOR");
        }
    }
}
