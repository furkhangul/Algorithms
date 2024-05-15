//Sayıyı basamaklarına göre ayıran program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        string sayi = Console.ReadLine();

        Console.WriteLine($"Girdiğiniz sayı {sayi.Length} basamaklıdır.");

        for (int i = 0; i < sayi.Length; i++)
        {
            int basamakDegeri = int.Parse(sayi[i].ToString()) * (int)Math.Pow(10, sayi.Length - i - 1);
            Console.WriteLine($"{i + 1}. BASAMAĞINIZ: {basamakDegeri}");
        }

        Console.WriteLine();
    }
}
