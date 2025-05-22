//Write a program to search an element in an array
using System;
class SearchElementInArray
{
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

        // Prompt the user for the element to search
        Console.WriteLine("Enter the element to search:");
        int searchElement = Convert.ToInt32(Console.ReadLine());

        // Search for the element in the array
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == searchElement)
            {
                Console.WriteLine("Element " + searchElement + " found at index " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element " + searchElement + " not found in the array.");
        }
    }
}