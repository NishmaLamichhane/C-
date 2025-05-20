// Write a program to generate the multiplication table for a given number
using System;
class MultiplicationTablee
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to generate its multiplication table:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the multiplication table
        Console.WriteLine("Multiplication table for " + number + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }
}