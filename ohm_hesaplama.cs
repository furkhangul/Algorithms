//İletkenin direnci ile içinden geçen akım yardımı ile uçlardaki gerilimi hesaplama
using System;
class Program
{
   static void Main()
    {
        Console.WriteLine("Lütfen iletkenin direncini giriniz(R):");
        string direnc = Console.ReadLine();
        Console.WriteLine("Lütfen iletkenden geçen akımı giriniz(A):");
        string amper = Console.ReadLine();
        double ohm = double.Parse(direnc) * double.Parse(amper);
        Console.WriteLine("Girdiğiniz iletkenin gerilimi {0} Ohm'dur.", ohm);
        Console.ReadLine();
    }
}
