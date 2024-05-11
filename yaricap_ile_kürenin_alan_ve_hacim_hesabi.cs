//Yarıçapı girilen kürenin alanını ve hacmini hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen kürenin yarıçapını giriniz:");
        string yaricap = Console.ReadLine();
        double alan = int.Parse(yaricap)*int.Parse(yaricap)*4*Math.PI;
        double hacim = int.Parse(yaricap) * int.Parse(yaricap) * int.Parse(yaricap) * 4 / 3 * Math.PI;
        Console.WriteLine("Giridiğiniz kürenin alanı: {0}",alan);
        Console.WriteLine("Giridiğiniz kürenin hacmi: {0}", hacim);

        Console.ReadLine();
    }
}
