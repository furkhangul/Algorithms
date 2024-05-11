//Viette Formülleri
using System;

class Program
{
    static void Main(string[] args)
    {
        double x1, x2, ktop, kcarp;
        Console.WriteLine("1.Kök: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2.Kök: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        ktop = x1 + x2;
        kcarp = x1 * x2;
        if( ktop < 0)
        {
            Console.WriteLine("\nx^2+{0}x",(-1)*ktop);
        }
        else
        {
            Console.WriteLine("\n x^2-{0}x", ktop);
        }
        if( kcarp < 0)
        {
            Console.WriteLine("Değer: {0}", kcarp);
        }
        else
        {
            Console.WriteLine("+{0}",kcarp);
        }

        Console.ReadLine();
    }
}

