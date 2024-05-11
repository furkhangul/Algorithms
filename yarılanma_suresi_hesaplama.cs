//Radyoaktif maddenin yarılanma süresi girilirken ne kadar süre geçeceğini ve kalan madde miktarını hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen maddeninbaşlangıç kütlesini giriniz:");
        string m = Console.ReadLine();
        Console.WriteLine("Girdiğiniz maddenin mol mikatır:{0}", mol);
        Console.WriteLine("Lütfen maddenin yarılanma süresini giriniz: ");
        string dT = Console.ReadLine();
        Console.WriteLine("Lütfen yanması için geçen toplam süresini giriniz: ");
        string t = Console.ReadLine();
        double maddeMiktari =  double.Parse(t) / double.Parse(dT);
        double mol = double.Parse(m) / maddeMiktari;
        Console.WriteLine("Girilen maddenin kalan kütlesi: {0}", m);
        Console.WriteLine("Girilen maddenin mol miktarı {0}",mol);

        Console.ReadLine();
    }
}
