using System;

namespace Exercise.Entities
{
    public class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
    }
}
