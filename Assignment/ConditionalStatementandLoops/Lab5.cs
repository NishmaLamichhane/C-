//Write a program to find the factorial of a number using a for loop
using System;
class FactorialCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to find its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the factorial variable
        long factorial = 1;

        // Calculate the factorial using a for loop
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // Display the result
        Console.WriteLine("The factorial of " + number + " is: " + factorial);
    }
}