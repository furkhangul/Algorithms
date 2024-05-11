//Heron Formülü
//Tüm kenarlarının uzunluğu bilinen üçgenin alanını hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen üçgenin 1.uzunluğunu giriniz:");
        string uzunluk1 = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin 2.uzunluğunu giriniz:");
        string uzunluk2 = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin 3.uzunluğunu giriniz:");
        string uzunluk3 = Console.ReadLine();
        int u = (int.Parse(uzunluk1) + int.Parse(uzunluk2) + int.Parse(uzunluk3) ) / 2;
        double alan = Math.Sqrt(u * (u - int.Parse(uzunluk1)) * (u - int.Parse(uzunluk2)) * (u - int.Parse(uzunluk3)));
        Console.WriteLine("Girdiğiniz üçgenin alanı: {0}", alan);
        Console.ReadLine();
    }
}
