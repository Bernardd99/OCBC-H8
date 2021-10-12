using System;

public class Bernard_028_assignment1
{

    public static void Main()
    {

        const string nama = "Bernard", nomorPeserta = "FSDO001ONL028", alamat = "Jambi";
        int input;
        string kembali;

        Console.WriteLine("---Assignment 1---");
        Console.WriteLine("==================");
        Console.WriteLine("Selamat Datang di Assignment 1");
        Console.WriteLine();
        Console.WriteLine("Nama Lengkap : " + nama);
        Console.WriteLine("Nomor Peserta : " + nomorPeserta);
        Console.WriteLine("Alamat Lengkap : " + alamat);
        Console.WriteLine("==================");
        Console.WriteLine();

        do
        {
            Console.WriteLine();
            Console.WriteLine("---Menu---");
            Console.WriteLine("1. Soal 1 (Segitiga Alfabet)");
            Console.WriteLine("2. Soal 2 (Segitiga Angka)");
            Console.WriteLine("3. Soal 3 (Faktorial)");
            Console.WriteLine("4. Soal 4 (Balik Angka)");
            Console.WriteLine("5. Soal 5 (Convert Angka ke String)");
            Console.WriteLine("6. Soal 6 (Palyndrome)");
            do
            {
                Console.Write("Please Input The Menu Number[1-6] : ");
                input = int.Parse(Console.ReadLine());
            } while (input < 1 || input > 6);

            switch (input)
            {
                //di case pertama ini saya tambahkan agar user bisa input ingin berapa baris segitiga yang diinginkan dari 1-26 baris,
                //jika ingin menampilkan jawaban seperti soal maka tinggal menginput 5 / mengganti variabel baris pada looping for menjadi 5
                case 1:
                    {
                        char start = 'A';
                        int baris, i, j, k, l;

                        Console.WriteLine();
                        Console.WriteLine("---Segitiga Alfabet---");
                        do
                        {
                            Console.Write("Enter the desired amount of triangle's row [1-26] : ");
                            baris = int.Parse(Console.ReadLine());
                        } while (baris < 1 || baris > 26);

                        for (i = 1; i <= baris; i++)
                        {
                            for (j = baris; j >= i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(start++);
                            }
                            start--;
                            for (l = 1; l < i; l++)
                            {
                                Console.Write(--start);
                            }
                            Console.Write("\n");
                            start = 'A';
                        }
                        break;
                    }
                case 2:
                    {
                        int angka = 1;
                        int baris, i, j, k, l;

                        Console.WriteLine();
                        Console.WriteLine("---Segitiga Angka---");

                        Console.Write("Enter the desired amount of triangle's row : ");
                        baris = int.Parse(Console.ReadLine());

                        for (i = 1; i <= baris; i++)
                        {
                            for (j = baris; j >= i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (k = 1; k <= i; k++)
                            {
                                Console.Write(angka++);
                            }
                            angka--;
                            for (l = 1; l < i; l++)
                            {
                                Console.Write(--angka);
                            }
                            Console.Write("\n");
                            angka = 1;
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine();
                        Console.WriteLine("---Faktorial---");

                        Console.Write("Enter any number : ");
                        int num = int.Parse(Console.ReadLine());
                        int temp = 1;

                        for (int i = num; i >= 1; i--)
                        {
                            temp = temp * i;
                        }
                        Console.WriteLine($"Factorial of {num} is: {temp}");

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine();
                        Console.WriteLine("---Balik Angka---");

                        int temp = 0;

                        Console.Write("Enter any number : ");
                        int num = int.Parse(Console.ReadLine());

                        for (int i = 0; num != 0; i++)
                        {
                            temp = temp * 10 + (num % 10);
                            num = num / 10;
                        }
                        Console.WriteLine("Reversed Number : " + temp);

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine();
                        Console.WriteLine("---Convert Angka ke String---");

                        int temp = 0, mod;

                        Console.Write("Enter any number : ");
                        int num = int.Parse(Console.ReadLine());

                        for (int i = 0; num > 0; i++)
                        {
                            temp = temp * 10 + (num % 10);
                            num = num / 10;
                        }
                        num = temp;
                        for (int i = 0; num > 0; i++)
                        {
                            mod = num % 10;

                            switch (mod)
                            {
                                case 1:
                                    Console.Write("one ");
                                    break;
                                case 2:
                                    Console.Write("two ");
                                    break;
                                case 3:
                                    Console.Write("three ");
                                    break;
                                case 4:
                                    Console.Write("four ");
                                    break;
                                case 5:
                                    Console.Write("five ");
                                    break;
                                case 6:
                                    Console.Write("six ");
                                    break;
                                case 7:
                                    Console.Write("seven ");
                                    break;
                                case 8:
                                    Console.Write("eight ");
                                    break;
                                case 9:
                                    Console.Write("nine ");
                                    break;
                                case 0:
                                    Console.Write("zero ");
                                    break;
                            }
                            num = num / 10;
                        }
                        Console.WriteLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine();
                        Console.WriteLine("---Palyndrome---");

                        string word, palyndrome = "";

                        Console.Write("Enter any word : ");
                        word = Console.ReadLine();

                        for (int i = word.Length - 1; i >= 0; i--)
                        {
                            palyndrome = palyndrome + word[i].ToString();
                        }

                        if (palyndrome == word)
                        {
                            Console.WriteLine($"Your word is {word} and the reversed word is {palyndrome}, Your word is Palyndrome.");
                        }
                        else
                        {
                            Console.WriteLine($"Your word is {word} and the reversed word is {palyndrome}, Your word is not Palyndrome.");
                        }
                        break;
                    }
            }
            Console.WriteLine();
            Console.WriteLine("Kembali ke menu awal?[Y/N] : ");
            kembali = Console.ReadLine().ToLower();
        } while (kembali == "y");
        Console.WriteLine("Sampai Jumpa!");
    }
}
