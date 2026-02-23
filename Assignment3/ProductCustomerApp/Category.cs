using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ProductCustomerApp
{
    [DataContract]
    public class Category
    {
        [DataMember]
        public required string CategoryName { get; set; }

        [DataMember]
        public required List<Product> Products { get; set; }
    }
}