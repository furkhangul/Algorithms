//Matris Oluşturma
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
        Console.Clear();
        Console.WriteLine("Girdiğiniz Matrisin Çıktısı:");
        for(int i = 0;i < boyut; i++)
        {
            for (int j = 0;j < boyut; j++)
            {
                Console.Write(matris[i,j] + " ");
            }
            Console.WriteLine("\n");
        }
                

        Console.ReadLine();
    }
}
