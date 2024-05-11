//İki uzunluğu ve bir açısı bilinen üçgenin alanını hesaplama
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen üçgenin 1.kenarını giriniz:");
        string ilk_uzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin 2.kenarını giriniz:");
        string ikinci_uzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen iki uzunluk arasında kalan açıyı giriniz:");
        string acı = Console.ReadLine();
        int alan = int.Parse(ilk_uzunluk) ^ 2 + int.Parse(ikinci_uzunluk) ^ 2 - 2 * int.Parse(ikinci_uzunluk) * int.Parse(ilk_uzunluk) * Math.Cos(int.Parse(acı);
        Console.WriteLine("Giridiğiniz Üçgenin Alanı: {0}",alan);
        Console.ReadLine();
    }
}
