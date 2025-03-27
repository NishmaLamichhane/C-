/*
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
*/
using System;
class pattern1
{
    public static void Main()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}