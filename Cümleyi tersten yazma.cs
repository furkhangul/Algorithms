//Girilen cümleyi tersten yazan program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();
        for (int i = 0; i < cumle.Length; i++)
        {
            char degisken;
            degisken = cumle[cumle.Length - 1 -i];
            Console.Write(degisken);
        }
 
    }
}
