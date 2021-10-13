using System;

public class Overloading
{
    public string nama;
    public double nomor_telepon;

    public void print(string nama)
    {
        this.nama = nama;
        Console.WriteLine($"Namanya adalah : {this.nama} ");
    }

    public void print(double nomor_telepon)
    {
        this.nomor_telepon = nomor_telepon;
        Console.WriteLine($"Nomor HP : {this.nomor_telepon}");
    }
}