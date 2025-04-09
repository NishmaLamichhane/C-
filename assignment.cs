// Create a simple class named Person that contains basic information like name, age, gender, etc.. Your class should also 
//contain function/method for storing and displaying code.
// The class should be able to store the data and display it when required.
using System;

class Person
{
    // Fields to store person data
    string name;
    int age;
    string gender;

    // Method to store data
    public void StoreData(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    // Method to display data
    public void DisplayData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
    }

    // Main method to test the class
    static void Main(string[] args)
    {
        Person p = new Person();
        p.StoreData("Nishma", 20, "Female");
        p.DisplayData();

        // Keep the console open
        Console.ReadLine();
    }
}
