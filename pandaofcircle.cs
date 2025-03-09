using System;
public class Perimeter{
    public static void Main(){
        Console.Write("Enter the radius of circle: ");
        double radius=Convert.ToDouble(Console.ReadLine());
        double perimeter=2*3.14*radius;
        Console.WriteLine("The perimeter of the circle is: "+perimeter);
        double area=3.14*radius*radius;
        Console.WriteLine("The area of the circle is: "+area);
    }
}