using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class PrivateConstructor
    {
        string Name;
        private PrivateConstructor()
        {
            Console.WriteLine("This is the private constructor");
        }
    }
}
