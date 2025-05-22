//Crete a methods that returns the sum of two numbers
using System;
class SumOfTwoNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = AddNumbers(num1, num2);
        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
    }
    // Method to add two numbers
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}