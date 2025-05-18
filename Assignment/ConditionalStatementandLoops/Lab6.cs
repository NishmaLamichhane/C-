//Create a program that prints the Fibonacci series up to n terms
using System;
class FibonacciSeries
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number of terms in the Fibonacci series:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Initialize the first two terms
        int a = 0, b = 1;

        // Display the Fibonacci series
        Console.WriteLine("Fibonacci series up to " + n + " terms:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int nextTerm = a + b;
            a = b;
            b = nextTerm;
        }

        Console.WriteLine();
    }
}