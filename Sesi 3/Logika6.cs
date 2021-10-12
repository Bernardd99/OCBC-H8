using System;

public class Logika6
{

    public static void Main()
    {

        Console.Write("Silahkan Input : ");
        int input = int.Parse(Console.ReadLine());

        while (input < 20)
        {
            Console.WriteLine("Nilai = " + input);
            input += 1;
        }
    }
}