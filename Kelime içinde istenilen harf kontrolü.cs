//Girilen cümledeki kelimelerin kaç tanesinde istenilen harf kullanıldığını bulan program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen cümlenizi giriniz: ");
        string cumle = Console.ReadLine();

        Console.WriteLine("Lütfen kontrol etmek istediğiniz harfi giriniz: ");
        char hedefHarf = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int kelimeSayisi = 0;
        int harfiIcerenKelimeSayisi = 0;

        string kelime = "";

        foreach (char c in cumle)
        {
            if (c == ' ')
            {
                if (kelime.Length > 0)
                {
                    kelimeSayisi++;
                    if (KelimeIceriyorMu(kelime, hedefHarf))
                    {
                        harfiIcerenKelimeSayisi++;
                    }
                    kelime = "";
                }
            }
            else
            {
                kelime += c;
            }
        }

        if (kelime.Length > 0)
        {
            kelimeSayisi++;
            if (KelimeIceriyorMu(kelime, hedefHarf))
            {
                harfiIcerenKelimeSayisi++;
            }
        }

        Console.WriteLine($"Cümledeki toplam kelime sayısı: {kelimeSayisi}");
        Console.WriteLine($"Cümledeki \"{hedefHarf}\" harfini içeren kelime sayısı: {harfiIcerenKelimeSayisi}");
    }

    static bool KelimeIceriyorMu(string kelime, char harf)
    {
        foreach (char c in kelime)
        {
            if (c == harf)
            {
                return true;
            }
        }
        return false;
    }
}
