//Yerden yüksekliği ve ilk hızı girilen cismin havada kalma süresini, yatayda aldığı yolu ve yere çarpma hızını hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen cismin ilk hızını giriniz(metre/saniye cinsinden):");
        string hiz = Console.ReadLine();
        Console.WriteLine("Lütfen cismin yerden yüksekliğini giriniz(metre cinsinden):");
        string yukseklik = Console.ReadLine();
        double sure = Math.Sqrt(2 * int.Parse(yukseklik)/9.8);
        double yol = int.Parse(hiz) * sure;
        double dikekYereCarpmaHiz = sure * 9.8;
        double yereCarpmaHiz = Math.Sqrt(dikekYereCarpmaHiz * dikekYereCarpmaHiz + int.Parse(hiz) * int.Parse(hiz));
        Console.WriteLine("Girdiğiniz cismin havada kalma süresi:{0}", sure);
        Console.WriteLine("Girdiğiniz cismin yatayda aldığı yolç: {0}", yol);
        Console.WriteLine("Girdiğiniz cismin dikeyde yere çarpma hızı: {0}", dikekYereCarpmaHiz);
        Console.WriteLine("Girdiğiniz cismin yere çarpma hızı: {0}",yereCarpmaHiz);
        Console.ReadLine();
    }
}
