//Matrisin N.satırındaki elemanların toplamını hesaplama
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kare matris boyutunu giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[boyut, boyut];

        for(int i = 0; i < boyut; i++)
        {
            for(int j = 0; j < boyut; j++)
            {
                Console.WriteLine("LÜtfen matrisinizin {0}.satırın {1}.sütunundaki sayıyı giriniz: ",i+1,j+1);
                matris[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int toplam = 0 ;
        Console.Clear();
        Console.WriteLine("Girdiğiniz Matrisin 2.Satırındaki Elemanların Toplamının Çıktısı:");
        for(int i = 0;i < boyut; i++)
        {
            toplam += matris[2, i];
        }
        Console.WriteLine(toplam);        

        Console.ReadLine();
    }
}
