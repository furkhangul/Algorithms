//Birim matris ile ders ve öğrenci sayısını kullanarak ortalama hesaplama
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen kaç öğrenci olduğunu giriniz : ");
        int ogrenci = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen kaç ders olduğunu giriniz : ");
        int ders = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[ogrenci,ders];
        for (int i = 0; i < ders; i++)
        {
            for (int j = 0; j < ders; j++)
            {
                Console.WriteLine("Lütfen {0}.Öğrencinin {1}.dersinin notunu giriniz: ",i+1,j+1);
                matris[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Clear();
        Console.WriteLine("Her bir dersteki sınıf ortalaması: ");
        for(int i = 0;i < ders; i++)
        {
            int toplam = 0;
            for(int j = 0;j < ogrenci; j++)
            {
                toplam += matris[i, j];
            }
            double ortalama = toplam / ogrenci;
            Console.WriteLine("{0}.dersin sınıf ortalaması: {1}",i+1,ortalama);
        }
        Console.ReadLine();
    }
}
