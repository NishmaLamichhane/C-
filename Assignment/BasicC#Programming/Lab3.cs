//Check whether a given number is prime or not in simple way
using System;
class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        // Declare an integer variable
        int number;

        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it's prime:");
        number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Display the result
        if (isPrime)
        {
            Console.WriteLine(+number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(+number + " is not a prime number.");
        }
    }
}