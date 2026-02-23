using System;
using System.Linq;

namespace ProductCustomerApp
{
    public class Customer : ICustomer
    {
        public required string CompanyName { get; set; }
        public required string City { get; set; }
    }
}
