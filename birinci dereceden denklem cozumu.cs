//Birinci dereceden iki denklemin çözümü
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci Denklem: ax + by = c");
        Console.WriteLine("İkinci Denklem: dx + ey = f");
        Console.WriteLine("Gireceğimiz değerler ile x ve y değerlerini bulmayı hedefliyoruz.");
        Console.WriteLine("Lütfen a değerini giriniz: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen b değerini giriniz: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen c değerini giriniz: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen d değerini giriniz: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen e değerini giriniz: ");
        double e = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Lütfen f değerini giriniz: ");
        double f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("1.Denklem: {0}x + {1}y = {2}", a, b, c);
        Console.WriteLine("2.Denklem: {0}x + {1}y = {2}", d, e, f);

        double x = ((c * e) - (f * b)) / ((a * e) - (d * b));
        double y = ((c * d) - (f * a)) / ((b * d) - (e * a));

        Console.WriteLine("Girdiğiniz Denklemlerde x değişkeni = {0}", x);
        Console.WriteLine("Girdiğiniz Denklemlerde y değişkeni = {0}", y);

        Console.ReadLine();
    }
}

