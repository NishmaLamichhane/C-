//Write a C# program to sort name of 10 persons in alphabetical order.
using System;
public class AlphabeticalOrder{
    public static void Main(){
        string[] names = new string[10];
        Console.WriteLine("Enter the names of 10 persons:");
        for(int i=0;i<10;i++){
            names[i]=Console.ReadLine();
        }
        Array.Sort(names);
        Console.WriteLine("The names of 10 persons in alphabetical order are:");
        for(int i=0;i<10;i++){
            Console.WriteLine(names[i]);
        }
    }
}