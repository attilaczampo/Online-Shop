using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class PrivateConstructor
    {
        static PrivateConstructor instance;
        private PrivateConstructor()
        {
            Console.WriteLine("This is the private constructor");
        }

        public static PrivateConstructor GetInstance()
        {
            if(instance == null)
                instance= new PrivateConstructor();
            return instance;
        }
    }
}
