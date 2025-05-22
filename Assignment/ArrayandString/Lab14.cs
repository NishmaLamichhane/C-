//Accept a string from the user and check if it is a palindrome.
using System;
class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        string reversedInput = ReverseString(input);

        if (input.Equals(reversedInput, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}