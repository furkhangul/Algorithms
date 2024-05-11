//Bir sayının tam bölenlerini yazdırma.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen sayıyı giriniz:");
        string number = Console.ReadLine();
        int sayi = int.Parse(number);
        int sayac = 0;
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                sayac++;
            }
        }

        int[] dizi = new int[sayac];
        int index = 0;
        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                dizi[index] = i;
                index++;
            }
        }
        for (int i = 0; i < sayac; i++)
        {
            Console.WriteLine("{0} sayısı {1} sayısına tam bölünür.", dizi[i], sayi);
        }
        Console.WriteLine("{0} sayısının {1} tane tam böleni vardır.", sayi, sayac);
        Console.ReadLine();
    }
}
