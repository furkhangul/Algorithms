//Kütlesi, hızı ve yerden yüksekliği bilinen maddenin potansiyel ve kinetik enerjisinin hesaplanması
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen cismin kütlesini giriniz (kilogram cinsinden):");
        string kutle = Console.ReadLine();
        Console.WriteLine("Lütfen cismin hızını giriniz(metre/saniye cinsinden):");
        string hiz = Console.ReadLine();
        Console.WriteLine("Lütfen cismin yerden yüksekliğini giriniz(metre cinsinden):");
        string yukseklik = Console.ReadLine();
        double potansiyel = int.Parse(kutle) * int.Parse(yukseklik) * 9.8;
        double kinetik = int.Parse(kutle) * int.Parse(hiz) * int.Parse(hiz) / 2;
        Console.WriteLine("Girdiğiniz cismin potansiyel enerjisi: {0}", potansiyel);
        Console.WriteLine("Girdiğiniz cismin kinetik enerjisi: {0}", kinetik);
        Console.ReadLine();
    }
}
