//Üçgenin Alanını Hesaplayan Basit Algoritma
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen üçgenin taban uzunluğunu giriniz:");
        string tabanUzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz: ");
        string yukseklik = Console.ReadLine();
        int alan = (int.Parse(yukseklik) * int.Parse(tabanUzunluk))/2;
        Console.WriteLine("Üçgeninizin alanı: {0}", alan);
        Console.ReadLine();
    }
}
