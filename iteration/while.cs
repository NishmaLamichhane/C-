using System;
public class While{
    public static void Main(){
        int i=1 , sum=0;
        while(i<=25){
            sum+=i;
            i++;
        }
        Console.WriteLine("Sum of first 25 natural numbers is "+sum);
    }
}