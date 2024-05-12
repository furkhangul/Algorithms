//Akrep ile Yelkovan arasında kalan açıyı hesaplama
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen saati giriniz: ");
        int saat = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Lütfen dakikayı giriniz: ");
        int dakika = Convert.ToInt16(Console.ReadLine());
        int saatdeger = 30 * saat;
        int dakikadeger = 6 * dakika;
        if(saatdeger > dakikadeger)
        {
            Console.WriteLine("{0}", saatdeger - dakikadeger);
        }
        else
        {
            Console.WriteLine("{0}", dakikadeger - saatdeger);

        }


        Console.ReadLine();
    }
}

