//Example of runtime polymorphism in C# using override keywords
using System;

namespace PolymorphismExample
{
    // Base class
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Another derived class
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal;

            myAnimal = new Dog();
            myAnimal.Speak(); // Output: The dog barks.

            myAnimal = new Cat();
            myAnimal.Speak(); // Output: The cat meows.

            Console.ReadLine();
        }
    }
}