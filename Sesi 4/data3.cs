using System;

public class data3
{

    public static void Main()
    {

        int i, j;
        int[,] tabel = new int[3, 4];

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 4; j++)
            {
                tabel[i, j] = (i * 4) + j + 1;
                Console.Write(tabel[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}