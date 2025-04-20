/** Create two different classes named Rose and Lily and add specific method relevant to that type of class.
Then create another class named flower that inherits from both Rose and Lily.Show how to achieve it using C#.
**/
using System;

interface IRose {
    void Rose_details();
}

interface ILily {
    void Lily_details();
}

public class Flower : IRose, ILily {
    public void Rose_details() {
        Console.WriteLine("This is rose details");
    }

    public void Lily_details() {
        Console.WriteLine("This is lily details");
    }

    public void Flower_details() {
        Console.WriteLine("This is flower details");
    }
}

class FinalProgram {
    static void Main(string[] args) {
        Flower f = new Flower();
        f.Rose_details();
        f.Lily_details();
        f.Flower_details();
    }
}
