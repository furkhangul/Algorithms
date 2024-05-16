//Palindromik  kelime programı
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen kelime giriniz: ");
        string kelime = Console.ReadLine();
        bool palindrom = true;

        for (int i = 0; i < kelime.Length / 2; i++)
        {
            if (kelime[i] != kelime[kelime.Length - i - 1])
            {
                palindrom = false;
                break;

            }

        }
        if(palindrom)
        {
            Console.WriteLine("Girdiğiniz sayı palindromik sayıdır. ");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı palindormik sayı değildir.");
        }

        
        Console.WriteLine();
    }
}
