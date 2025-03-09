using System;

public class Relational
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (a > b && a>c)
        {
            Console.WriteLine("The largest number is: " + a);
        }
        else if(b>a&&b>c)
        {
            Console.WriteLine("The largest number is: " + b);
        }
         else
        {
            Console.WriteLine("The largest number is: " + c);
        }
       if (a < b && a<c)
        {
            Console.WriteLine("The smallest number is: " + a);
        }
        else if(b<a&&b<c)
        {
            Console.WriteLine("The smallest number is: " + b);
        }
         else
        {
        Console.WriteLine("The smallest number is: " + c);
        }
    }
}
