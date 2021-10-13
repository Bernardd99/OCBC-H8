using System;

public class Pesawat
{

    private string nama;
    private int jumlahroda;
    private string tinggi;
    private string jumlahpenumpang;

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public int JumlahRoda
    {
        get { return jumlahroda; }
        set { jumlahroda = value; }
    }

    public string Ketinggian
    {
        get { return tinggi; }
        set { tinggi = value; }
    }

    public string JumlahPenumpang
    {
        get { return jumlahpenumpang; }
        set { jumlahpenumpang = value; }
    }

    public void terbang()
    {
        Console.WriteLine($"\nPesawat dengan nama {this.Nama}, yang mempunyai jumlah roda {this.JumlahRoda}, sedang berada pada ketinggian {this.Ketinggian}, dengan membawa jumlah penumpang sebanyak {this.JumlahPenumpang} akan meledakkan senjata");
    }

}