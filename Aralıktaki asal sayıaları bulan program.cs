//Belirili bir aralıktaki bütün asal sayıları bulan program
using System;

class Program
{
    static void Main(string[] args)
    {
        int taban, tavan;
        while (true)
        {
            Console.WriteLine("Lütfen taban sayınızı giriniz:");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen tavan sayınzı giriniz: ");
            tavan = Convert.ToInt32(Console.ReadLine());
            if(taban > tavan)
            {
                continue;
            }
            else
            {
                break;
            }
        }

        for (int i = taban; i <= tavan; i++)
        {
            int sayac = 0;
            for (int j = 1; j <= tavan; j++)
            {
                if (i % j == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("{0} sayısı asal sayıdır !", i);
            }
        }

        Console.ReadLine();
    }
}
