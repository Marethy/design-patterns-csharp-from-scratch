using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Domain
{
    public interface IInvoiceGenerator
    {
        void GenerateInvoice(string orderId, decimal amount);
    }

}
