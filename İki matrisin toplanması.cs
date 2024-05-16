//İki matrisin toplanmasını sağlayan program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kare matris boyutunu giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[,] matris1 = new int[boyut, boyut];

        for(int i = 0; i < boyut; i++)
        {
            for(int j = 0; j < boyut; j++)
            {
                Console.WriteLine("LÜtfen 1. matrisinizin {0}.satırın {1}.sütunundaki sayıyı giriniz: ",i+1,j+1);
                matris1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[,] matris2 = new int[boyut, boyut];

        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.WriteLine("LÜtfen 2. matrisinizin {0}.satırın {1}.sütunundaki sayıyı giriniz: ", i + 1, j + 1);
                matris1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[,] matris3 = new int[boyut, boyut];

        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                matris3[i,j] = matris1[i,j] + matris2[i,j];
            }
        }




        Console.Clear();
        Console.WriteLine("Girdiğiniz Matrisin Toplamının Çıktısı:");
        for(int i = 0;i < boyut; i++)
        {
            for (int j = 0;j < boyut; j++)
            {
                Console.Write(matris3[i,j] + " ");
            }
            Console.WriteLine("\n");
        }
                

        Console.ReadLine();
    }
}
