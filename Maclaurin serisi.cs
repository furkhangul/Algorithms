//Maclaurin Serileri ile e^x hesaplama
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("x değerini girin: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("N değerini girin: ");
        int N = Convert.ToInt32(Console.ReadLine());

        double result = MaclaurinSeries(x, N);
        Console.WriteLine("e^x ≈ " + result);

        Console.ReadLine();
    }

    static double MaclaurinSeries(double x, int N)
    {
        double sum = 1.0; 

        for (int i = 1; i <= N; i++)
        {
            sum += Math.Pow(x, i) / Factorial(i);
        }

        return sum;
    }

    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
