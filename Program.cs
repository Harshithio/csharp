using System;

namespace ConstructorExamples
{
    class Person
    {
        public string Name;
        public int Age;
        public static int InstanceCount;

        // 1. Default Constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default Constructor called");
        }

        // 2. Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized Constructor called");
        }

        // 3. Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Console.WriteLine("Copy Constructor called");
        }

        // 4. Static Constructor
        static Person()
        {
            InstanceCount = 0;
            Console.WriteLine("Static Constructor called");
        }

        // 5. Private Constructor (changed to use int to avoid conflict)
        private Person(int secretCode)
        {
            Console.WriteLine("Private Constructor called with secret code: " + secretCode);
        }

        // 6. Constructor Overloading
        public Person(string name)
        {
            Name = name;
            Age = 18; // default age
            Console.WriteLine("Constructor Overload called with name only");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Factory method to use private constructor
        public static Person CreateSecretPerson()
        {
            return new Person(007);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating person1 with default constructor:");
            Person person1 = new Person();
            person1.Display();

            Console.WriteLine("\nCreating person2 with parameterized constructor:");
            Person person2 = new Person("Alice", 30);
            person2.Display();

            Console.WriteLine("\nCreating person3 with copy constructor:");
            Person person3 = new Person(person2);
            person3.Display();

            Console.WriteLine("\nCreating person4 with constructor overload:");
            Person person4 = new Person("Bob");
            person4.Display();

            Console.WriteLine("\nCreating secret person using private constructor via static method:");
            Person secretPerson = Person.CreateSecretPerson();
        }
    }
}
