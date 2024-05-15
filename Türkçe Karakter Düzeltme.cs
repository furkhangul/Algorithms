//Klavyeden girilen Türkçe karakterleri düzelten program
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir girdi oluşturunuz: ");
        string cumle = Console.ReadLine();

        string duzeltilmisCumle = Duzelt(cumle);

        Console.WriteLine("Düzeltildi: " + duzeltilmisCumle);
    }

    static string Duzelt(string cumle)
    {
        string duzeltilmisCumle = "";

        foreach (char c in cumle)
        {
            switch (c)
            {
                case 'ı':
                    duzeltilmisCumle += 'i';
                    break;
                case 'İ':
                    duzeltilmisCumle += 'I';
                    break;
                case 'ü':
                    duzeltilmisCumle += 'u';
                    break;
                case 'Ü':
                    duzeltilmisCumle += 'U';
                    break;
                case 'ö':
                    duzeltilmisCumle += 'o';
                    break;
                case 'Ö':
                    duzeltilmisCumle += 'O';
                    break;
                case 'ç':
                    duzeltilmisCumle += 'c';
                    break;
                case 'Ç':
                    duzeltilmisCumle += 'C';
                    break;
                default:
                    duzeltilmisCumle += c;
                    break;
            }
        }

        return duzeltilmisCumle;
    }
}
