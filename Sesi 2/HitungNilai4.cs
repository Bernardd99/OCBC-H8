using System;

class HitungNilai4{

    public static void Main(){

        Console.Write("Enter Your Age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password : ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";

        if(isAdult && isPasswordValid){
            Console.WriteLine("Welcome to The Club!");
        }else{
            Console.WriteLine("Sorry, try again!");
        }
        
    }
}