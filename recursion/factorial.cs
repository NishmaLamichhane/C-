using System;
public class Factorial{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        long result = Fact(number);
        Console.WriteLine($"Factorial of {number} is {result}");
    }

    static long Fact(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Fact(n - 1);
    }
}