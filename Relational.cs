using System;

public class Relational
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("The largest number is: " + a);
        }
        else
        {
            Console.WriteLine("The largest number is: " + b);
        }
          if (a < b)
        {
            Console.WriteLine("The smallest number is: " + a);
        }
        else
        {
            Console.WriteLine("The smallest number is: " + b);
        }
    }
}
