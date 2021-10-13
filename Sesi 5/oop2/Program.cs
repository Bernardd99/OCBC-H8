using System;

namespace oop2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Pesawat pesawat = new Pesawat();
            Console.Write("\nMasukan nama pesawat : ");
            pesawat.nama = Console.ReadLine();
            Console.Write("Masukan ketinggian pesawat : ");
            pesawat.ketinggian = Console.ReadLine();

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();


        }
    }
}
