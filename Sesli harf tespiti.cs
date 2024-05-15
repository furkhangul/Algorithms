//Klavyeden girilen cümlenin sesli harflerini ve yerlerini bulan program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir cümle giriniz: ");
        string girdi = Console.ReadLine();
        for (int i = 0;i<girdi.Length;i++)
        {
            if (girdi[i] == 'i' || girdi[i] == 'e' || girdi[i]=='a' || girdi[i] == 'u' || girdi[i] == 'ü' || girdi[i] == 'o' || girdi[i] == 'ö' || girdi[i] == 'ı' )
            {
                Console.WriteLine("Girdiğiniz cümlenin {0}.harfinde sesli harf tespit edilmiştir ! ", i + 1);
            }
        }
    }
}
