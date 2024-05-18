//C# ile dostya açma ve kapatma işlemi
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Gerçek kullanıcı adınızı belirtin ve dizin adlarını İngilizce karakterlerle belirtin
        string dosyaYolu = @"C:\Users\Furkan\Desktop\new.txt";
        FileStream dosya = File.Create(dosyaYolu);
        dosya.Close();

        Console.ReadLine();
    }
}
