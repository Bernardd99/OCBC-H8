using System;

public class data1
{

    public static void Main()
    {

        int[] aAngka = new int[5] { 1, 2, 3, 4, 5 };
        string[] aNama = new string[] { "Joni", "Meri", "David" };
        object[] aObjek = { 20.33, "Lorem Ipsum", DateTime.Now, true, 'D' };

        for (int i = 0; i < aAngka.Length; i++)
        {
            Console.Write(aAngka[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < aNama.Length; i++)
        {
            Console.Write(aNama[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < aObjek.Length; i++)
        {
            Console.WriteLine(aObjek[i]);
        }

    }
}