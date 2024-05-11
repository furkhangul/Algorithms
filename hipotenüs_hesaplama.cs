//İki uzunluğu bilinen üçgenin hipotenüsünü hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen üçgenin 1.kenarını giriniz:");
        string ilk_uzunluk = Console.ReadLine();
        Console.WriteLine("Lütfen üçgenin 2.kenarını giriniz:");
        string ikinci_uzunluk = Console.ReadLine();
        double hipotenus = Math.Sqrt(int.Parse(ilk_uzunluk) ^ 2 + int.Parse(ikinci_uzunluk) ^ 2);
        Console.WriteLine("Giridiğiniz Üçgenin Hipotenüsü: {0}",hipotenus);
        Console.ReadLine();
    }
}
