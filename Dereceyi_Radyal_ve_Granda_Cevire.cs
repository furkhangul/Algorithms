//Derece Cinsinden Girilen Açıyı "Radyan" ve "Grad" Cinsine Çeviren Program (Kolay olum ama yapacaz işte ♥)
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen çevirmek istediğiniz dereceyi giriniz:");
        string derece = Console.ReadLine();
        double radyal = double.Parse(derece) * (int)Math.PI / 180;
        double grand = double.Parse(derece) * 200 / 180;
        Console.WriteLine("Girdiğiniz derecenin radyal cinsinden değeri: {0}", radyal);
        Console.WriteLine("Girdiğiniz derecenin grand cinsinden değeri: {0}", grand);
        Console.ReadLine();
    }
}
