//Otomatik açılan dosyaya gerekli bilgileri ekleyen program
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen adınızı giriniz: ");
        string isim = Console.ReadLine();
        Console.Write("Lütfen soyadınızı giriniz: ");
        string soyisim = Console.ReadLine();
        Console.Write("Lütfen ID giriniz: ");
        string id = Console.ReadLine();

        string dosyaYolu = @"C:\Users\Furkan\Desktop\new.txt";

        try
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                sw.WriteLine("Adınız: {0}\nSoyadınız: {1}\nID'niz: {2}", isim, soyisim, id);
            }
            Console.WriteLine("Dosya başarıyla oluşturuldu.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dosya oluşturulurken bir hata oluştu: " + ex.Message);
        }

        Console.ReadLine();
    }
}
