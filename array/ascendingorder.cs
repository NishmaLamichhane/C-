using System;
public class AscendingOrder{
    public static void Main(){
Console.WriteLine("Enter the number of elements:");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr= new int [n];
Console.WriteLine("Enter the elements:");
for(int i=0;i<n;i++){
    arr [i] =Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<n-1;i++){
    for(int j=0;j<n-i-1;j++){
if(arr[j]>arr[j+1]){
    int temp=arr[j];
    arr[j]=arr[j+1];
    arr[j+1]=temp;
}  
}
}
Console.WriteLine("The elements in ascending order are:");
for(int i=0;i<n;i++){
    Console.WriteLine(arr[i]);
    }
    }
}