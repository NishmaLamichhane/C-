//Implement a multilevel inheritance using own simple example
using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("Mammal is walking");
    }
}
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Program1
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat(); // Inherited from Animal
        dog.Walk(); // Inherited from Mammal
        dog.Bark(); // Dog's own method
    }
}