using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class ParameterizedConstructor
    {
        string WatchBrand;
        string WatchDescription;
        int WatchPrice;
        public ParameterizedConstructor(string watchBrand, string watchDescription, int watchPrice)
        {
            this.WatchBrand = watchBrand;
            this.WatchDescription = watchDescription;
            this.WatchPrice = watchPrice;
        }
        
        public void PrintParamConstr()
        {
            Console.WriteLine("\t");
            Console.WriteLine("Your watch is: " + WatchBrand);
            Console.WriteLine("Watch description: " + WatchDescription);
            Console.WriteLine("Watch price: " + WatchPrice);
            Console.WriteLine("\t");
        }
    }
}
