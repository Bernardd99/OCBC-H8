using System;

public class Program
{
    public static void Main()
    {

        //instant objek
        Laptop laptop1 = new Laptop();

        //akses atribut
        laptop1.merk = "lenovo";
        laptop1.ram = 4;
        laptop1.memory = 128;

        //tampilkan
        Console.WriteLine("\nMerk Laptop adalah : ");
        laptop1.merk = Console.ReadLine();
        Console.WriteLine("Kapasitas Ram adalah : ");
        laptop1.ram = int.Parse(Console.ReadLine());
        Console.WriteLine("Kapasitas Memory adalah : ");
        laptop1.memory = int.Parse(Console.ReadLine());

        //akses method
        laptop1.Chatting();
        laptop1.Sosmed();
        laptop1.OnlineShop();

        //contoh 1 method
        laptop1.run();
        Console.Read();

    }
}