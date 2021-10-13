using System;

public class Laptop
{
    //Atrribute/Variable
    public string merk;
    public int ram;
    public int memory;

    //Method
    public void Chatting()
    {
        Console.WriteLine("\n{0} sedang chatting", this.merk);
    }
    public void Sosmed()
    {
        Console.WriteLine("{0} sedang sosmed", this.merk);
    }
    public void OnlineShop()
    {
        Console.WriteLine("{0} sedang online shop", this.merk);
    }

    //contoh 1 method
    public void run()
    {
        Console.WriteLine("\n{0} sedang chatting", this.merk);
        Console.WriteLine("{0} sedang sosmed", this.merk);
        Console.WriteLine("{0} sedang online shop", this.merk);
    }

}