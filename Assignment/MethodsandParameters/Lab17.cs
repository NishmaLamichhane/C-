// Create a method to calculate factorial of a number using recursion
using System;
class Factorial1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = CalculateFactorial(number);
        Console.WriteLine("The factorial of " + number + " is: " + result);
    }

    static int CalculateFactorial(int num)
    { 
        if (num == 0 || num == 1)
            return 1;
        else
            return num * CalculateFactorial(num - 1);
    }
}