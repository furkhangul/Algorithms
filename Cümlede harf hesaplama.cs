//Girilen cümlede istenilen harften kaç tane kullanılıdığnı hesaplama
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();
        Console.WriteLine("Lütfen hesaplanacak harfi giriniz:");
        char harf = Convert.ToChar(Console.ReadKey().KeyChar);
        Console.ReadLine();
        int sayac = 0;
        for (int i = 0; i < cumle.Length; i++)
        {
            if (cumle[i] == harf)
            {
                sayac++;
            }
        }
        Console.WriteLine("Girdiğiniz '{0}' cümlesinde {1} defa '{2}' harfi kullanıldı.", cumle, sayac, harf);
        Console.ReadLine();
    }
}
