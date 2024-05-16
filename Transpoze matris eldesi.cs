//Bir matrisin transpozesini alan program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kare matris boyutunu giriniz: ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[boyut, boyut];
        int[,] transpoze = new int[boyut, boyut];

        for(int i = 0; i < boyut; i++)
        {
            for(int j = 0; j < boyut; j++)
            {
                Console.WriteLine("LÜtfen matrisinizin {0}.satırın {1}.sütunundaki sayıyı giriniz: ",i+1,j+1);
                matris[i,j] = Convert.ToInt32(Console.ReadLine());
                transpoze[j,i] = matris[i,j];
            }
        }
        Console.WriteLine("Girdiğiniz matrisin transpozesi: ");

        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write(transpoze[i,j] +" ");
            }
            Console.WriteLine("\n");
        }

        Console.ReadLine();
    }
}
