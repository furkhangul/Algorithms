//Girilen sayının kombinsayonlarının hesaplanması.
using System;
class Program
{
    static void Main(string[] args)
    {
        int faktoriyelN = 1;
        int faktoriyelR = 1;
        int faktoriyelP = 1;
        Console.Write("Lütfen kombinasyonu hesaplanacak eleman sayısını giriniz: ");
        string sayi = Console.ReadLine();
        int n = int.Parse(sayi);
        Console.Write("Lütfen girilen eleman sayısının kaçıncı konbinasyonuun hesaplanacağını giriniz: ");
        string derece = Console.ReadLine();
        int r = int.Parse(derece);

        if(r > n)
        {
            Console.WriteLine("Girdiğiniz değer eleman sayısından fazla. Lütfen geçerli bir kombinasyon giriniz !");
            Console.ReadLine();
        }
        else
        {
            for(int i = 1; i <= n; i++)
            {
                faktoriyelN *= i;
            }
            for(int i = 1;i <= r; i++)
            {
                faktoriyelR *= i;
            }
            for ( int i = 1; i <= (n-r); i++)
            {
                faktoriyelP *= i;
            }

            int permutasyon = faktoriyelN / faktoriyelR * faktoriyelP;
            Console.WriteLine("Girdiğniiz eleman sayısının {0}. permütasyonu : {1}",r,permutasyon);
            Console.ReadLine();
        }
    }
}
