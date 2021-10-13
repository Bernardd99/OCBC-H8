using System;

public class Pesawat
{
    public string nama;
    private string tinggi;

    public string ketinggian
    {
        get { return tinggi; }
        set { tinggi = value; }
    }

    public void terbang()
    {
        Console.WriteLine("\nPesawat dengan nama {0}, sedang take off", this.nama);
    }

    public void sudahterbang()
    {
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0} Kaki", this.tinggi);
    }
}