//Girilen sayının tek mi çift mi olduğunu hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen tek mi çift mi olduğunu bulmak istediğiniz sayıyı giriniz:");
        string sayi = Console.ReadLine();
        int deger = int.Parse(sayi);
        if(deger % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz değer çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz değer tektir.");
        }
        Console.ReadLine();
    }
}
