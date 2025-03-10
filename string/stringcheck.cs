using System;
public class Stringcheck{
    public static void Main(){
        Console.Write("Enter first string: ");
        string a=Console.ReadLine();
        Console.Write("Enter second string: ");
        string b=Console.ReadLine();
        int s=a.CompareTo(b);
        if(s==0){
            Console.WriteLine("The strings are equal.");
        }
        else if(s<0){
            Console.WriteLine("The string 1 is smaller.");
        }
        else{
            Console.Write("The string 1 is larger.");
        }
}
}