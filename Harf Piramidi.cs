//Bir kelimeyi piramit şeklinde yazan program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Kelime Giriniz: ");
        string kelime = Console.ReadLine();

        for (int i = 0;i<kelime.Length;i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                Console.Write(kelime[j]);
            }
            Console.WriteLine("\n");
        }
        Console.ReadLine();
    }
}
