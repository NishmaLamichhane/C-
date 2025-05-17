//Create a program that swaps two integers without using a third variable.
using System;
class SwapIntegers
{
    static void Main(string[] args)
    {
        // Declare two integer variables
        int a, b;

        // Prompt the user for input
        Console.WriteLine("Enter the first integer:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        b = Convert.ToInt32(Console.ReadLine());

        // Display the original values
        

        // Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);

        // Swap the values without using a third variable
        a = a + b;
        b = a - b;
        a = a - b;

        // Display the swapped values
              Console.WriteLine("After swapping: a = " + a + ", b = " + b);

    }
}