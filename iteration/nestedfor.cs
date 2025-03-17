using System;
public class NestedFor
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* "); // Use Write instead of WriteLine
            }
            Console.WriteLine(); // Move to the next line after inner loop
        }
    }
}
