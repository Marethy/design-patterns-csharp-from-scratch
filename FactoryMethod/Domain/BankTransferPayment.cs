using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class BankTransferPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bank Transfer of {amount:C}");
        }
    }

}
