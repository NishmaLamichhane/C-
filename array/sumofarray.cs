using System;

class Program
{
    static void Main()
    {
        int[] array ={1,2,3,4,5,6,7};
        int sum=0;
        for(int i=0;i<array.Length;i++)
        {
            sum+=array[i];
        }
        Console.WriteLine("The sum of the array is:"+sum);
    }
}