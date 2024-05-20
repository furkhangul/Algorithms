//Girilen sayının asal sayı olup olmadığını kontrol eden program
using System;

class Program
{
    static void Main(string[] args)
    {
        int sayac = 0;
        Console.Write("Lütfen bir sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool asalMi = false;
        if(number <= 1)
        {
            asalMi=false;
        }

        else
        {  
            for(int i=2; i <= number; i++)
            {
                if(number %i == 0)
                {
                    sayac++;
                }
            }
        }


        if (sayac == 1)
        {
            asalMi = true;
        }


        if (asalMi)
        {
            Console.WriteLine("Girdiğiniz {0} sayısı asaldır. ", number);
        }
        else
        {
            Console.WriteLine("Girdiğiniz {0} sayısı asal sayı değildir. ", number);

        }
            Console.ReadLine();
    }
}
