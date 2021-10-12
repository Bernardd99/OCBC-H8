using System;

class HitungNilai5{

    public static void Main(){
        
        int pertama, kedua, ketiga, total;
        double rata;
        string mStatus, gStatus;

        Console.Write("Username : ");
        string username = Console.ReadLine();
        Console.Write("Password : ");
        string password = Console.ReadLine();
        Console.Write("Enter Your Age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Your Gender[L/P] : ");
        string gender = Console.ReadLine();
        Console.Write("Enter Marital Status[Y/N] : ");
        string status = Console.ReadLine();

        bool isName = username == "Bernard";
        bool isPasswordValid = password == "OCBC";
        bool isAdult = age > 18;

        gStatus = gender == "L" ? "Laki-Laki" : "Perempuan";
        mStatus =  status == "Y" ? "Married" : "Not Married";

        if(isName && isAdult && isPasswordValid){
            Console.WriteLine("Welcome to The Club!");

            Console.WriteLine();
            Console.WriteLine("===Biodata===");
            Console.WriteLine("Username : " + username);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gStatus);
            Console.WriteLine("Marital Status : " + mStatus);
            Console.WriteLine();

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
            Console.WriteLine("Total Rata-rata Nilai adalah : " + rata);
        }else{
            Console.WriteLine("Sorry, try again!");
        }

        
    }
}