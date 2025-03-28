//Write a C# program to generate multiplication table from 1 to 10.
using System;

public class MultiplicationTable
{
    public static void Main()
    {
        Console.WriteLine("==== Multiplication Table (1 to 10) ====\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Multiplication Table of {i}:");
            Console.WriteLine("---------------------------");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }

            Console.WriteLine(); 
        }
    }
}
