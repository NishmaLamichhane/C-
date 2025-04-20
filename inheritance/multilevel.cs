/*Create a class called Employee that inherits from Person and adds a method Employee_details()
then, create another class called Manager that inherits from Employee and add a method department() using
C#.
**/
using System;

class IPerson {
    public void message() {
        Console.WriteLine("Person details are: Nishma");
    }

    public void name() {
        Console.WriteLine("Name is: Nishma");
    }
}

class Employee : IPerson {
    public void employee_details() {
        Console.WriteLine("This is employee details");
    }
}

class Manager : Employee {
    public void department() {
        Console.WriteLine("Department is: IT");
    }
}

class Programs{
    static void Main(string[] args) {
        Manager m = new Manager();
        m.message();             
        m.name();                
        m.employee_details();    
        m.department();          
    }
}
