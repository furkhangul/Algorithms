//Çarpma operatörünü kullanmadan çarpma işlemi yapan program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen çarpılacak 1.sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen çarpılacak 2.sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int sayac = 0;
        for(int i = 0; i < sayi1; i++)
        {
            sayac = sayac + sayi2;
        }
        Console.WriteLine("Girdiğiniz iki değerin çarpımı: {0}", sayac);
        Console.ReadLine();
    }
}
