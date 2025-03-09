using System;
public class Perimeter{
    public static void Main(){
        Console.Write("Enter the length of the rectangle");
        double length= Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the breadth of the rectangle");
        double breadth= Convert.ToDouble(Console.ReadLine());
        double perimeter=2*(length+breadth);
        Console.WriteLine("The perimeter of the rectangle is: "+perimeter);
        double area=length*breadth;
        Console.WriteLine("The area of the rectangle is: "+area);
    }
}