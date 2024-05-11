//Yarıçapı ve açısı bilinen daire diliminin alanını hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen çemberin yarıçapını giriniz:");
        string yaricap = Console.ReadLine();
        Console.WriteLine("Lütfen aradaki açıyı giriniz (Derece cinsinden): ");
        string derece = Console.ReadLine();
        double parcaAlan = int.Parse(yaricap) * int.Parse(yaricap) * Math.PI * double.Parse(derece) / 360;
        Console.WriteLine("Giridiğiniz çemberdeki parçanın alanı: {0}",parcaAlan);

        Console.ReadLine();
    }
}
