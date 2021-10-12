using System;

public class Logika5
{

    public static void Main()
    {

        DateTime date = DateTime.Now;
        Console.WriteLine("Hari ini bulan : " + date.ToString("MMMM"));
        Console.WriteLine();

        // int input = date.month;

        Console.Write("Silahkan Input [1-12] : ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                {
                    Console.WriteLine("Januari");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Februari");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Maret");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("April");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Mei");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Juni");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Juli");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Agustus");
                    break;
                }
            case 9:
                {
                    Console.WriteLine("September");
                    break;
                }
            case 10:
                {
                    Console.WriteLine("Oktober");
                    break;
                }
            case 11:
                {
                    Console.WriteLine("November");
                    break;
                }
            case 12:
                {
                    Console.WriteLine("Desember");
                    break;
                }
        }

        //     string[] bulan = new string[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
        //     int input;

        //     Console.Write("Silahkan input [1-12] : ");
        //     input = int.Parse(Console.ReadLine());
        //     Console.WriteLine(bulan[input-1]);
    }
}