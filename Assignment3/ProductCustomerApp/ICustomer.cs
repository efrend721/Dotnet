using System;
using System.Linq;

namespace ProductCustomerApp
{
    public interface ICustomer
    {
        string CompanyName { get; set; }
        string City { get; set; }
    }
}
