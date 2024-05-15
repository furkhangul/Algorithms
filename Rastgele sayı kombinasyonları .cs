//Rastgele sayı kombinasyonları 
using System;

class Program
{
    static void Main()
    {
        Random rastgele = new Random();
        int[] kullaniciSayilari = new int[6];
        Console.WriteLine("Lütfen 1 ile 49 arasında 6 farklı tam sayı girin:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            kullaniciSayilari[i] = int.Parse(Console.ReadLine());
            if (kullaniciSayilari[i] < 1 || kullaniciSayilari[i] > 49)
            {
                Console.WriteLine("Hatalı giriş. Lütfen 1 ile 49 arasında bir sayı girin.");
                i--; 
            }
            else if (Array.IndexOf(kullaniciSayilari, kullaniciSayilari[i], 0, i) != -1)
            {
                Console.WriteLine("Bu sayıyı daha önce girdiniz. Lütfen farklı bir sayı girin.");
                i--; 
            }
        }

        int[] rasgeleSayilar = new int[6];
        for (int i = 0; i < 6; i++)
        {
            int yeniSayi;
            do
            {
                yeniSayi = rastgele.Next(1, 50);
            } while (Array.IndexOf(rasgeleSayilar, yeniSayi) != -1);

            rasgeleSayilar[i] = yeniSayi;
        }
        Console.WriteLine("\nRasgele Sayılar: " + string.Join(", ", rasgeleSayilar));
        Console.WriteLine("Kullanıcı Sayıları: " + string.Join(", ", kullaniciSayilari));
        int eslesmeSayisi = 0;
        foreach (int kullaniciSayisi in kullaniciSayilari)
        {
            if (Array.IndexOf(rasgeleSayilar, kullaniciSayisi) != -1)
            {
                eslesmeSayisi++;
            }
        }
        Console.WriteLine($"Tutulan sayıların sayısı: {eslesmeSayisi}");
    }
}
