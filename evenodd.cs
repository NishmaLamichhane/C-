using System;
public class Evenodd{
    public static void Main(){
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        if(a%2==0){
            Console.WriteLine("Even Number");
        }
        else{
            Console.WriteLine("Odd Number");
        }
    }
}