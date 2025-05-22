//Accept a number and print whether it is even or odd using if else
using System;
class EvenOddCheck
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it's even or odd:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even or odd using if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is an odd number.");
        }
    }
}