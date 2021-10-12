using System;

class Task1
{

    public static void Main()
    {

        string uname, password;

        Console.Write("Enter Username : ");
        uname = Console.ReadLine();
        Console.Write("Enter Password : ");
        password = Console.ReadLine();

        if (uname == "ocbc" && password == "bootcamp")
        {
            Console.WriteLine("Anda berhasil login!");
        }
        else
        {
            Console.WriteLine("Username atau Password salah");
        }
    }
}