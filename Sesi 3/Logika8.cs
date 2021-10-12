using System;

public class Logika8
{

    public static void Main()
    {

        Console.Write("Silahkan Input Angka : ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("Ingin diulang berapa kali? : ");
        int input1 = int.Parse(Console.ReadLine());



        Console.WriteLine("1. Penambahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");
        Console.WriteLine("5. Basic");
        Console.Write("Pilih Operasi : ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                {
                    for (int i = 1; i < input1 + 1; i++)
                    {
                        Console.WriteLine($"i = {i + input}");
                    }
                    break;
                }
            case 2:
                {
                    for (int i = 1; i < input1 + 1; i++)
                    {
                        Console.WriteLine($"i = {i - input}");
                    }
                    break;
                }
            case 3:
                {
                    for (int i = 1; i < input1 + 1; i++)
                    {
                        Console.WriteLine($"i = {i * input}");
                    }
                    break;
                }
            case 4:
                {
                    for (int i = 1; i < input1 + 1; i++)
                    {
                        Console.WriteLine($"i = {i / input}, Hasil bagi = {i % input}");
                    }
                    break;
                }
            case 5:
                {
                    do
                    {
                        Console.WriteLine($"i = {input}");
                        input++;

                        if (input > input1 + 1)
                        {
                            break;
                        }

                    } while (input < input1 + 1);
                }
        }


    }
}