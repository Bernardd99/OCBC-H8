using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string fname, lname;
        int age;

        Console.WriteLine("Hello World");

        Console.WriteLine("Enter Your First Name: ");
        fname = Console.ReadLine();

        Console.WriteLine("Enter Your Last Name: ");
        lname = Console.ReadLine();

        Console.WriteLine("Enter Your Age: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Your Name Is " + fname + " " + lname);
        Console.WriteLine("Your Age Is " + age);
    }
}