//ASCII kodu ile harf tespiti
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir girdi oluşturunuz: ");
        string cumle = Console.ReadLine();
        for (int i = 0;i<cumle.Length;i++)
        {
            if (cumle[i] <=65 && cumle[i] <= 90)
            {
                Console.Write((char)(cumle[i] + 32));
               
            }
            else
            {
                Console.Write((char)(cumle[i] - 32));
            }
        }

            
    }
}
