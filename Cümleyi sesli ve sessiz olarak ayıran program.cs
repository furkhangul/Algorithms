//Cümleyi sesli ve sessiz harfler olarak ayıran program
using System;

class Program
{
    static void Main(string[] args)
    {
        int sesliSayac = 0;
        int sessizSayac = 0;
        Console.Write("Lütfen bir cümle giriniz: ");
        string girdi = Console.ReadLine();
        for (int i = 0; i < girdi.Length; i++)
        {
            if (girdi[i] == 'i' || girdi[i] == 'e' || girdi[i] == 'a' || girdi[i] == 'u' || girdi[i] == 'ü' || girdi[i] == 'o' || girdi[i] == 'ö' || girdi[i] == 'ı' || girdi[i] == 'İ' || girdi[i] == 'E' || girdi[i] == 'A' || girdi[i] == 'U' || girdi[i] == 'Ü' || girdi[i] == 'O' || girdi[i] == 'Ö' || girdi[i] == 'I')
            {
                sesliSayac++;
            }
            else if (char.IsLetter(girdi[i])) // Harf mi kontrolü
            {
                sessizSayac++;
            }
        }

        char[] sesli = new char[sesliSayac];
        char[] sessiz = new char[sessizSayac];
        int sesliArt = 0;
        int sessizArt = 0;

        for (int i = 0; i < girdi.Length; i++)
        {
            if (girdi[i] == 'i' || girdi[i] == 'e' || girdi[i] == 'a' || girdi[i] == 'u' || girdi[i] == 'ü' || girdi[i] == 'o' || girdi[i] == 'ö' || girdi[i] == 'ı' || girdi[i] == 'İ' || girdi[i] == 'E' || girdi[i] == 'A' || girdi[i] == 'U' || girdi[i] == 'Ü' || girdi[i] == 'O' || girdi[i] == 'Ö' || girdi[i] == 'I')
            {
                sesli[sesliArt] = girdi[i];
                sesliArt++;
            }
            else if (char.IsLetter(girdi[i])) // Harf mi kontrolü
            {
                sessiz[sessizArt] = girdi[i];
                sessizArt++;
            }
        }

        Console.Write("Sessiz Kelimelerin Derlenmesi: ");
        for (int i = 0; i < sessiz.Length; i++)
        {
            Console.Write(sessiz[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Sesli Kelimelerin Derlenmesi: ");
        for (int i = 0; i < sesli.Length; i++)
        {
            Console.Write(sesli[i] + " ");
        }
        Console.WriteLine();
    }
}
