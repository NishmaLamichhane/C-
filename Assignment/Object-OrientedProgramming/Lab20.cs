//Demonstrate method overloading with ADD(int , int) and ADD(float, float)
using System;

class MethodOverloading
{
    // Method to add two integers
    static int ADD(int a, int b)
    {
        return a + b;
    }

    // Method to add two floats
    static float ADD(float a, float b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        // Integer addition
        int intResult = ADD(5, 10);
        Console.WriteLine("Addition of integers: " + intResult);

        // Float addition
        float floatResult = ADD(5.5f, 10.2f);
        Console.WriteLine("Addition of floats: " + floatResult);
    }
}

