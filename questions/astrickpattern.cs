//Write a program to following pattern.
/*  
* * * * *
* * * * 
* * *
* *
* 
*/
using System;
public class AstrickPattern{
    public static void Main(){
        int i,j;
        for(i=5; i>=1; i--){
            for(j=1; j<=i; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}