//Accept a string and reversed it without using any built-in functions
using System;
class ReverseString
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();

        // Reverse the string without using built-in functions
        char[] reversedArray = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            reversedArray[i] = input[input.Length - 1 - i];
        }

        // Convert the character array back to a string
        string reversedString = new string(reversedArray);

        // Display the reversed string
        Console.WriteLine("Reversed string: " + reversedString);
    }
}