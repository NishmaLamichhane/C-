using System;
using System.Security.Cryptography;

public class Braek
{
    public void breakk()
    {
        int n = 0;
        while (true)
        {
            n++;
            if (n == 10)
            {
                break;
            }
        }
        Console.WriteLine(n);
    }

    public void continuee()
    {
        int n = 0;
        while (n < 10)
        {
            n++;
            if (n == 5)
            {
                continue;
            }
            Console.WriteLine(n);
        }
    }
    public void returnn()
    {
        int n = 0;
        while (n < 10)
        {
            n++;
            if (n == 5)
            {
                return;
            }
            Console.WriteLine(n);
        }
    }
    public void gotoo()
    {
        int n = 0;
        loop:
        n++;
        if (n < 10)
        {
            Console.WriteLine(n);
            goto loop;
        }
    }
    public void throws()
    {
     Console.WriteLine("Enter a age");
        int n=Convert.ToInt32(Console.ReadLine());
        if(n<18)
        {
            throw new Exception("You are not eligible to vote");
        }
        else
        {
            Console.WriteLine("You are eligible to vote");
        }
    }
    public static void Main()
    {

        Braek obj = new Braek();
        obj.breakk();
        obj.continuee();
        obj.returnn();
        obj.gotoo();
        obj.throws();
    }
}
 