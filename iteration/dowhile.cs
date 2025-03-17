using System;
public class DoWhile{
    public static void Main(){
        int i=1 , sum=0;
        do{
            sum+=i;
            i++;
        }while(i<=25);
        Console.WriteLine("Sum of first 25 natural numbers is "+sum);
    }
}