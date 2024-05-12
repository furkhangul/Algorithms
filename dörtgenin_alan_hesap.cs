//Köşegenleri ve köşegenler arasındaki açı bilinen dörtgenin alanını  hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen üçgenin 1.köşegeni giriniz:");
        string ilk_uzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin 2.köşegeni giriniz:");
        string ikinci_uzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen köşegenler arasında kalan açıyı giriniz: ");
        string acı = Console.ReadLine();
        double alan = int.Parse(ilk_uzunluk)*int.Parse(ikinci_uzunluk)*Math.Sin(double.Parse(acı)*Math.PI/180)/2;
        Console.WriteLine("Giridiğiniz dörtgenin alanı: {0}",alan);
        Console.ReadLine();
    }
}

