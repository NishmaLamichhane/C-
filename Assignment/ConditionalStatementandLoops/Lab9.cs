//Use a switch statement to perform a simple calculator(Add,sub,mul,div).
using System;

class CalculatorA
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0; // Initialize result

        // Perform the calculation based on the chosen operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return; // Exit the program early
                }
                break;

            default:
                Console.WriteLine("Invalid operation.");
                return; // Exit the program early
        }

        // Display the result
        Console.WriteLine("Result: " + result);
    }
}
