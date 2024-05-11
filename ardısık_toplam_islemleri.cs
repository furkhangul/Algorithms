//Ardışık tek, ardışık çift ve ardışık sayıların toplamı ile alakalı toplam hesaplamaları.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen hesaplama yapılacak sayıyı giriniz: ");
        string deger = Console.ReadLine();
        int sayi = int.Parse(deger);
        int toplam = 0;
        //Ardışık sayıların toplamı (1 den n'e kadar toplamı)
        for(int i = 0; i <=sayi; i++)
        {
            toplam += i;
        }
        Console.WriteLine("Girdiğiniz değerin ardışık toplamı: {0}", toplam);
        //Ardışık çift ve tek sayıların ayrı ayrı toplamı (1 den n'e kadar ki çift ve tek sayıların toplamı)
        int sayac1 = 0;
        int sayac2 = 0;
        for (int i = 0; i <= sayi; i++)
        {
           if(sayi %2 == 0)
            {
                sayac1++;
            }
            else
            {
                sayac2++;
            }
        }
        int ciftSayac = 0;
        int tekSayac = 0;
        for(int i=0; i <= sayi; i++)
        {
            if(i %2 == 0)
            {
                ciftSayac += i;
            }
            else
            {
                tekSayac += i;
            }
        }
        Console.WriteLine("Girdiğiniz değerin ardışık tek toplamı: {0}", tekSayac);
        Console.WriteLine("Girdiğiniz değerin ardışık cift toplamı: {0}", ciftSayac);

        Console.ReadLine();
    }
}
