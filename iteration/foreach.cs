using System;

public class ForEach
{
    public static void Main()
    {
        int[] numbers = new int[25];
        for (int i = 0; i < 25; i++)
        {
            numbers[i] = i + 1;
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("The sum of the first 25 natural numbers is: " + sum);
    }
}