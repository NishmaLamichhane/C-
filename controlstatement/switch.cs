using System;
public class Switch{
    public static void Main(){
        int number = 30;
        switch(number){
            case 10:
                Console.WriteLine("Number is 10");
                break;
            case 20:
                Console.WriteLine("Number is 20");
                break;
            case 30:
                Console.WriteLine("Number is 30");
                break;
            default:
                Console.WriteLine("Number is not 10, 20 or 30");
                break;
        }
    }
}