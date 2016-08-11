using System.Collections.Generic;

namespace Exercise.Entities
{
    public class Order
    {
        public Person Person { get; }
        public Address DeliveryAddress { get; }
        public Address BillingAddress { get; }

        public List<Product> Products { get; }

        public Order(Person person, Address delivery, Address billing, List<Product> products)
        {
            Person = person;
            DeliveryAddress = delivery ?? billing;
            BillingAddress = billing;
            Products = products;
        }

        public bool QualifiesForDiscount()
        {
            const string name = "Alex";
            return name.Equals(Person?.Name);
        }

        public bool IsValid()
        {
            return BillingAddress?.Street != null && DeliveryAddress?.Street != null && Person?.Name != null;
        }
    }
}
