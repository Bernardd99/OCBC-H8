using System;

public class Bilangan
{
    public int bilangan1, bilangan2;

    public void bilangan(int angka1, int angka2)
    {
        bilangan1 = angka1;
        bilangan2 = angka2;
    }

    public virtual void penjumlahanperkaliandll()
    {
        Console.WriteLine("Overiding 1.....");
        Console.WriteLine($"Hasil penjumlahan angka {bilangan1} dan angka {bilangan2} = {bilangan1 + bilangan2}");
        Console.WriteLine($"Hasil perkalian angka {bilangan1} dan angka {bilangan2} = {bilangan1 * bilangan2}");
    }
}

public class Overiding : Bilangan
{

    public override void penjumlahanperkaliandll()
    {
        Console.WriteLine("Overiding 2.....");
        Console.WriteLine($"Hasil pembagian angka {bilangan1} dan angka {bilangan2} = {bilangan1 / bilangan2}");
        Console.WriteLine($"Hasil pengurangan angka {bilangan1} dan angka {bilangan2} = {bilangan1 - bilangan2}");
    }
}