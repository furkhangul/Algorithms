//Diziyi tersten yazan program
//FurOfTheWeak :)
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen gireceğiniz dizinin uzunluğunu giriniz: ");
        int uzunluk = Convert.ToInt32(Console.ReadLine());
        string[] dizi = new string[uzunluk];

        for (int i = 0; i < uzunluk; i++)
        {
            Console.WriteLine("Lütfen dizinizin {0}. elemanını giriniz: ", i + 1);
            dizi[i] = Console.ReadLine();
        }

        string[] degisecekDizi = new string[uzunluk];
        for (int i = 0; i < uzunluk; i++)
        {
            degisecekDizi[i] = dizi[uzunluk - i - 1];
        }

        Console.WriteLine("Dizinin tersten yazılmış hali: ");
        for (int i = 0; i < uzunluk; i++)
        {
            Console.WriteLine("{0}", degisecekDizi[i]);
        }

        Console.ReadLine();
    }
}
