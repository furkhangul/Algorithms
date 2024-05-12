//İki dizinin toplamı olan yeni dizi oluşturan program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen dizilere kaç sayı girmek istediğinizi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int[] dizi1 = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine("Lütfen 1. dizinin {0}. sayısını giriniz: ", i + 1);
            dizi1[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] dizi2 = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine("Lütfen 2. dizinin {0}. sayısını giriniz: ", i + 1);
            dizi2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] dizi3 = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            dizi3[i] = dizi1[i] + dizi2[i];
        }

        Console.WriteLine("Girdiğiniz Dizilerin Toplamı Olan Dizinin Elemanları: ");
        foreach (int eleman in dizi3)
        {
            Console.WriteLine(eleman);
        }

        Console.ReadLine();
    }
}
