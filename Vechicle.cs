using System;
public class Vechicle
{
public void wheeler(){
Console.WriteLine("Vechicle has two wheeler");
}
}
public class Bike:Vechicle{
public void tvs(){
Console.WriteLine("TVS is a bike");
}
}
class Program
{
public static void Main(){
Bike b=new Bike();
b.tvs();
b.wheeler();
}
}   