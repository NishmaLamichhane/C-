// Example of compile-time polymorphism in C#
using System;

class Calculator
{
    // Method Overloading
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class ProgramA
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Addition of two integers: " + calc.Add(5, 10));
        Console.WriteLine("Addition of three integers: " + calc.Add(5, 10, 15));
        Console.WriteLine("Addition of two doubles: " + calc.Add(5.5, 10.5));
    }
}