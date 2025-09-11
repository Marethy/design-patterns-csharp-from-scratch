using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PayPalService
    {
        public void MakePayment(decimal money) => Console.WriteLine($"[PayPal] Payment of {money} completed.");
    }
}
