//Write a C# program to generate multiplication table from 1 to 10.
using System;
public class multiplication{
    public static void Main(string[] args){
        int i, j;
        for(i=1; i<=10; i++){
            for(j=1; j<=10; j++){
                Console.Write(i*j + "\t");
            }
            Console.WriteLine();
        }
    }
}