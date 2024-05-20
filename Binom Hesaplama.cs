//Girilen sayının binomunu hesaplayn program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Binom açılımını hesaplamak için a, b ve n değerlerini girin:");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\nBinom açılımı:");
        for (int k = 0; k <= n; k++)
        {
            double binom = BinomialCoefficient(n, k);
            double term = binom * Math.Pow(a, n - k) * Math.Pow(b, k);
            Console.WriteLine($"{binom} * {a}^{n - k} * {b}^{k} = {term}");
        }
    }

    static double BinomialCoefficient(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static double Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
