// Create a class Student with fields name, roll number, and marks.Write methods to accept and display data with main method too.
using System;
class Student
{
    // Fields
    private string name;
    private int rollNumber;
    private double marks;

    // Method to accept data
    public void AcceptData()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter roll number: ");
        rollNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }


    // Method to display data
    public void DisplayData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Marks: " + marks);
    }
    static void Main(string[] args)
    {
        Student student = new Student();
        student.AcceptData();
        student.DisplayData();
    }
}