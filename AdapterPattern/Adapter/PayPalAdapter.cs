using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class PayPalAdapter(PayPalService payPalService) : IPaymentProcessor
    {
        public void Pay(decimal amount) =>
            payPalService.MakePayment(amount);
    }
}
