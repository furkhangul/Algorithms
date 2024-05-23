//Fibonacci Dizisi 
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen fibonaccinin kaçıncı terimine ulaşmak istediğinizi giriniz: ");
        int kat = Convert.ToInt16(Console.ReadLine());
        int ilkDeger = 1;
        int ikinciDeger = 1;
        Console.WriteLine("{0}.TERİME KADAR FİBONACCİ DİZİSİ",kat);
        Console.WriteLine(ilkDeger);
        Console.WriteLine(ikinciDeger);
        for (int i = 0; i < kat-2; i++)
        {
            int toplam = ilkDeger + ikinciDeger;
            Console.WriteLine(toplam);
            ilkDeger = ikinciDeger;
            ikinciDeger = toplam;

        }

        Console.ReadLine();
    }
}
