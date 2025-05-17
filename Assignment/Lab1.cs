//Basic C# pogramming
//Write a program to calculate the area of circle using radios as input.
using System;
class Circle
{
    static void Main(string[] args)
    {
        double radius, area;
        Console.WriteLine("Enter the radius of the circle:");
        radius = Convert.ToDouble(Console.ReadLine());
        area = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);
        Console.ReadLine();
    }
}
