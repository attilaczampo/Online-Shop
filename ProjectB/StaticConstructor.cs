using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public class StaticConstructor
    {
        public string LoanTaker;
        public int Id;
        public static float interestRate;

        public StaticConstructor(string loanTaker, int id)
        {
            LoanTaker = loanTaker;
            Id = id;
        }

        static StaticConstructor()
        {
            interestRate = 8.7f;
        }

        public void PrintStaticConstr()
        {
            Console.WriteLine("Loan takers name: " + LoanTaker + "; " + "Loan takers ID: " + Id + "; " + "Interest rate of: " + interestRate);
        }
    }
}
