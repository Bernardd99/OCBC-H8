using System;

namespace oop3
{
    class Program
    {

        public static void Main(string[] args)
        {
            string kembali = "";
            int input;

            do
            {

                Console.WriteLine("---Tugas---");
                Console.WriteLine("===========");
                Console.WriteLine("1. Pesawat Tempur");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. About Me");
                Console.WriteLine("===========");
                do
                {
                    Console.Write("Please Input[1-5] : ");
                    input = int.Parse(Console.ReadLine());
                } while (input < 1 || input > 5);

                switch (input)
                {
                    case 1:
                        {
                            Pesawat pesawat = new Pesawat();
                            PesawatTempur pTempur = new PesawatTempur();

                            pesawat.Nama = "Helly";
                            pesawat.JumlahRoda = 3;
                            pesawat.Ketinggian = "1000 kaki";
                            pesawat.JumlahPenumpang = "3 penumpang";
                            pTempur.Nama = "AZ500TPU";
                            pTempur.JumlahRoda = 5;
                            pTempur.Ketinggian = "200 kaki";
                            pTempur.JumlahPenumpang = "2 penumpang plus kopilot dan assitance";

                            pesawat.terbang();
                            pTempur.pterbang();
                            break;
                        }
                    case 2:
                        {
                            Overloading overload = new Overloading();

                            Console.Write("Masukan Nama : ");
                            string nama = Console.ReadLine();
                            Console.Write("Masukan Nomor Telepon : ");
                            string nomor_telepon = Console.ReadLine();

                            overload.print(nama);
                            overload.print(nomor_telepon);
                            break;
                        }
                    case 3:
                        {
                            Bilangan bilangan1 = new Bilangan();

                            Console.Write("Input bilangan pertama : ");
                            int bil1 = int.Parse(Console.ReadLine());
                            Console.Write("Input bilangan kedua : ");
                            int bil2 = int.Parse(Console.ReadLine());

                            bilangan1.bilangan(bil1, bil2);
                            bilangan1.penjumlahanperkaliandll();

                            bilangan1 = new Overiding();
                            bilangan1.bilangan(bil1, bil2);
                            bilangan1.penjumlahanperkaliandll();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nama saya Bernard, pengalaman saya bootcamp sejauh ini cukup menarik, karena C# adalah bahasa baru yang saya pakai\n");
                            break;
                        }
                    case 5:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                }

                Console.WriteLine("Ingin Kembali?[Y/N] : ");
                kembali = Console.ReadLine().ToLower();
            } while (kembali == "y");
        }
    }
}
