using System;

class String{

    public static void Main(){

        string nama;
        int umur;

        Console.WriteLine("=== Program Pendataan Penduduk ===");
        Console.Write("Masukkan Nama : ");
        nama = Console.ReadLine();
        Console.Write("Masukkan Alamat : ");
        var alamat = Console.ReadLine();
        Console.Write("Masukkan Umur : ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Terima Kasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama : {nama}");
        Console.WriteLine($"Alamat : {alamat}");
        Console.WriteLine($"Umur : {umur}"); 
        Console.WriteLine("Sudah Disimpan!");
    }
}