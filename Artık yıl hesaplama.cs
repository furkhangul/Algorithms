//Girilen yılın artık yıl olup olmadığını hesaplama
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen hesaplamak istediğiniz yılı giriniz: ");
        int year = Convert.ToInt16(Console.ReadLine());
        if(year %4==0)
        {
            if(year % 100 == 0)
            {
                Console.WriteLine("Girdiğiniz yıl artık yıl değildir !");
            }
            else
            {
                Console.WriteLine("Girdiğiniz yıl artık yıldır !");

            }
        }
        else
        {
            Console.WriteLine("Girdiğiniz yıl artık yıl değildir !");
        }

        Console.ReadLine();
    }
}
