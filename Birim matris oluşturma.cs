//Birim matris oluşturan program
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Birim matrisinizin kaça kaçlık olacağını giriniz : ");
        int boyut = Convert.ToInt32(Console.ReadLine());
        int[,] matris = new int[boyut,boyut];
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                if (!(i == j))
                {
                    matris[i, j] = 0;
                }
                else
                {
                    matris[i, j] = 1;

                }
            }
        }
        Console.Clear();
        Console.WriteLine("Girdiğiniz birim matris : ");
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write(matris[i, j] + " ");
                
            }
 ;           Console.WriteLine("\n");
        }

        Console.ReadLine();
    }
}
