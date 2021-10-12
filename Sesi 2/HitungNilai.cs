using System;

class HitungNilai{

    public static void Main(){

        int pertama, kedua, ketiga, total;
        double rata;

        Console.WriteLine("===Menghitung Nilai===");
        Console.Write("Masukan Nilai Pertama : ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan Nilai Kedua : ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan Nilai Ketiga : ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;
        Console.WriteLine("Total Nilai adalah : " + total);
        Console.WriteLine("Total Rata Nilai adalah : " + rata);
        Console.Read();
    }
}