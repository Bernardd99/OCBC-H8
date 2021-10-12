using System;

public class Logika2
{

    public static void Main()
    {

        Console.Write("Silahkan Input Nama : ");
        string nama = Console.ReadLine();
        Console.Write("Silahkan Input Nilai : ");
        int nilai = int.Parse(Console.ReadLine());

        if (nilai < 60)
        {
            Console.WriteLine($"{nama}, Nilai Kamu C");
        }
        else if (nilai < 80)
        {
            Console.WriteLine($"{nama}, Nilai Kamu B");
        }
        else
        {
            Console.WriteLine($"{nama}, Nilai Kamu A");
        }

    }
}