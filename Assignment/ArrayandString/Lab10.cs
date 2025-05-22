//Create a program that sorts an array in assending order.
using System;
class SortArray{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Declare an array to hold the elements
        int[] arr = new int[n];

        // Read the elements from the user
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sort the array in ascending order
        Array.Sort(arr);

        // Display the sorted array
        Console.WriteLine("Sorted array in ascending order:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}