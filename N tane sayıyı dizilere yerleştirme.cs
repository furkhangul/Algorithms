//N tane sayının diziye yerleştirilmesi
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
        foreach (int i in dizi)
        {
            Console.WriteLine("Girdiğiniz sayı: {0}",i);
        }
        Console.ReadLine();
    }
}
