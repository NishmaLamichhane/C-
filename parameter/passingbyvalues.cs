using System;
public class PassingByValues{
    public static void Foo(int p){
        p=p+1;
        Console.WriteLine(p);
    }
    public static void Main(){
        int x=8;
        Foo(x);
        Console.WriteLine(x);
    }
}