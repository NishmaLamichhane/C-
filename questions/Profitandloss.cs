//Write a program to input CP and SP and check profit or loss. Also calculate the profit or loss amount.
using System;
public class ProfitandLoss{
    public static void Main(){
        double cp,sp,profit,loss;
        Console.Write("Enter the cost price:");
        cp=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the selling price:");
        sp= Convert.ToDouble(Console.ReadLine());
        if(cp>sp){
            Console.WriteLine("Loss");
            loss=cp-sp;
            Console.WriteLine("Loss amount is: "+loss);
        }
        else if(sp>cp){
            Console.WriteLine("Profit");
            profit=sp-cp;
            Console.WriteLine("Profit amount is: "+profit);
        }
        else{
            Console.WriteLine("No profit no loss");
        }
    }
}