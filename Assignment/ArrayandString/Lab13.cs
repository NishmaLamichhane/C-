//Write a program to find the largest element in an 2D array
using System;
class LargestElementIn2DArray
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number of rows in the 2D array:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns in the 2D array:");
        int cols = Convert.ToInt32(Console.ReadLine());

        // Declare a 2D array to hold the elements
        int[,] arr = new int[rows, cols];

        // Read the elements from the user
        Console.WriteLine("Enter the elements of the 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Find the largest element in the 2D array
        int largestElement = arr[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] > largestElement)
                {
                    largestElement = arr[i, j];
                }
            }
        }

        // Display the largest element
        Console.WriteLine("The largest element in the 2D array is: " + largestElement);
    }
}