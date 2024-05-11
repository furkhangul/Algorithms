//İki sayının birbirine bölünebilirliği
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen ilk sayıyı giriniz:");
        string number1 = Console.ReadLine();
        int sayi1 = int.Parse(number1);
        Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
        string number2 = Console.ReadLine();
        int sayi2 = int.Parse(number1);
        if(sayi1 < sayi2)
        {
            Console.WriteLine("1.sayı 2.sayıdan küçük !");
        }
        else
        {
            if (sayi1 % sayi2 == 0)
            {
                Console.WriteLine("1.sayı 2.sayıya tam olarak bölünür");
        }
            else
            {
                Console.WriteLine("1.sayı 2. sayıya tan olarak bölünmeze !");
            }
        }
        Console.ReadLine();
    }
}
