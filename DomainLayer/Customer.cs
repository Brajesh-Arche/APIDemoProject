using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Customer:BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerLocation { get; set; }
        public string ProductName { get; set; }
        public string PaymentType { get; set; }
    }
}
