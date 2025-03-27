/*
1
2 2
3 3 3
4 4 4 4
5 5 5 5
*/
using System;
class pattern2
{
    public static void Main()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}