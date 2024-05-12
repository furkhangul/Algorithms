//N elemanlı dizinin elemanlarını toplama
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen diziye kaç sayı girmek istediğinizi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
         int[] dizi = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine("Lütfen {0}.sayıyı giriniz: ",i+1);
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        int toplam = 0;
        for (int i = 0;i < sayi; i++)
        {
            toplam = toplam + dizi[i];
        }
        Console.WriteLine("Toplamınız :{0}",toplam);
        Console.ReadLine();
    }
}
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen diziye kaç sayı girmek istediğinizi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
         int[] dizi = new int[sayi];
        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine("Lütfen {0}.sayıyı giriniz: ",i+1);
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        int toplam = 0;
        for (int i = 0;i < sayi; i++)
        {
            toplam = toplam + dizi[i];
        }
        Console.WriteLine("Toplamınız :{0}",toplam);
        Console.ReadLine();
    }
}
