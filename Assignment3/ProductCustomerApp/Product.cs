using System.Runtime.Serialization;

namespace ProductCustomerApp
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public required string ProductName { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }
    }
}
