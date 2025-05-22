//Write a program with a method that uses ref and out parameters.
using System;
class RefAndOutParameters
{
    static void Main(string[] args)
    {
        int number = 5;
        int result;
        //ref parameter is used to pass the variable by reference
        //out parameter is used to pass the variable by reference and it must be assigned a value before the method returns
        CalculateSquare(ref number, out result);
        Console.WriteLine("The square of the number is: " + result);
    }

    static void CalculateSquare(ref int num, out int square)
    {
        square = num * num;
    }
}