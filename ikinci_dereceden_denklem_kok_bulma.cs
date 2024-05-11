//İkinci dereceden denklemin hesaplanması
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** ax^2+bx+c şeklindeki ikinci dereceden denklemin çözümü.");
        Console.Write("Lütfen a değerini giriniz: ");
        string adegeri = Console.ReadLine();
        double a = double.Parse(adegeri);

        Console.Write("Lütfen b değerini giriniz: ");
        string bdegeri = Console.ReadLine();
        double b = double.Parse(bdegeri);

        Console.Write("Lütfen c değerini giriniz: ");
        string cdegeri = Console.ReadLine();
        double c = double.Parse(cdegeri);

        Console.WriteLine("Girdiğiniz Denklem: {0}x^2+{1}x+{2}", a, b, c);

        // Determinant hesaplama
        double determinant = b * b - 4 * a * c;

        // Köklerin hesaplanması
        if (determinant > 0)
        {
            double kok1 = (-b + Math.Sqrt(determinant)) / (2 * a);
            double kok2 = (-b - Math.Sqrt(determinant)) / (2 * a);

            Console.WriteLine("Girdiğiniz Denklemin 1.Kökü: {0}", kok1);
            Console.WriteLine("Girdiğiniz Denklemin 2.Kökü: {0}", kok2);
        }
        else if (determinant == 0)
        {
            double kok = -b / (2 * a);
            Console.WriteLine("Girdiğiniz Denklemin Çift Kökü: {0}", kok);
        }
        else
        {
            Console.WriteLine("Girdiğiniz Denklemin Gerçel Kökü Yoktur.");
        }

        Console.ReadLine();
    }
}
