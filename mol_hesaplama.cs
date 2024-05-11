//Kütlesi ve molekül ağırlığı yardımı ile maddenin molünü hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen maddenin molekül ağırlığını giriniz:");
        string mA = Console.ReadLine();
        Console.WriteLine("Lütfen maddenin kütlesini giriniz:");
        string m = Console.ReadLine();
        double mol = int.Parse(m) / int.Parse(mA);
        Console.WriteLine("Girdiğiniz maddenin mol mikatır:{0}", mol);
        Console.ReadLine();
    }
}
