//Perform addition and substraction of two numbers 'sum' and 'subract' using delegate
using System;
namespace DelegateExample
{
    // Define a delegate
    public delegate int Operation(int a, int b);

    class Program
    {
        // Method to perform addition
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method to perform subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            // Create delegate instances
            Operation addOperation = new Operation(Add);
            Operation subtractOperation = new Operation(Subtract);

            // Perform addition and subtraction
            int sum = addOperation(10, 5);
            int difference = subtractOperation(10, 5);

            // Display results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
        }
    }
}