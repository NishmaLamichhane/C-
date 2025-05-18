//Accept the string from the user and count the number of vowels
using System;

class VowelCounter
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine(); // Accept user input

        int vowelCount = 0; // Counter for vowels

        // Convert input string to lowercase to handle both uppercase and lowercase vowels
        string lowerCaseString = inputString.ToLower();

        // Loop through each character in the string
        foreach (char c in lowerCaseString)
        {
            // Check if the character is a vowel
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++; // Increment count if it's a vowel
            }
        }

        // Output the total number of vowels
        Console.WriteLine("The number of vowels in the string is: " + vowelCount);
    }
}
