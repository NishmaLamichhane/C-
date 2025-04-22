//Create a base class Vechicle and derive the classes Car, Truck and Motorcycle from it. Each dervied classes
//should add specific method relevant to that type of vechicle using C#.
using System;
public class IVechicle{
    public void Vechicle_details(){
        Console.WriteLine("This is vechicle details");
    }
}
public class Car:IVechicle{
    public void Car_details(){
        Console.WriteLine("This is car details");
    }
}
public class Truck:IVechicle{
    public void Truck_details(){
        Console.WriteLine("This is truck details");
    }
}
public class Motorcycle:IVechicle{
    public void Motorcycle_details(){
        Console.WriteLine("This is motorcycle details");
    }
}
// main class
class IProgram{
    static void Main(string[]args){
        Car c=new Car();
        c.Vechicle_details();
        c.Car_details();

        Truck t=new Truck();
        t.Vechicle_details();
        t.Truck_details();

        Motorcycle m=new Motorcycle();
        m.Vechicle_details();
        m.Motorcycle_details();
    }
}
