using System;

namespace Exercise.Entities
{
    public class Address
    {
        public string Street { get; }

        public Address(string street)
        {
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentNullException(nameof(street));

            Street = street;
        }
    }
}
