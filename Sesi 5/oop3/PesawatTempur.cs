using System;

public class PesawatTempur:Pesawat
{

    public void pterbang()
    {

        Console.WriteLine($"Pesawat tempur dengan nama {this.Nama}, yang mempunyai jumlah roda {this.JumlahRoda}, sedang berada pada ketinggian {this.Ketinggian}, dengan membawa jumlah penumpang sebanyak {this.JumlahPenumpang} akan meledakkan senjata");

    }
}