// See https://aka.ms/new-console-template for more information

using FundamentalCSharp;

class Program
{
    public static void Main(string[] args)
    {
        string x = string.Empty;

        do
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("             Senang Belajar C Sharp(C#)            ");
            Console.WriteLine("     Latihan Fundamental Bahasa Pemrograman C#     ");
            Console.WriteLine("===================================================");
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine("Modul Modul Belajar Bhs. Pemrogram C#");
            Console.WriteLine("1. Input & Output");
            Console.WriteLine("2. Operasi Aritmatika");
            Console.WriteLine("3. Kodisional Statement");
            Console.WriteLine("4. Looping Statement");
            Console.WriteLine("5. String Array List");
            Console.WriteLine("6. Integer Array List");
            Console.WriteLine("7. List Collections");
            Console.WriteLine("8. Game Tebak Angka");
            Console.WriteLine("9. Bersihkan Layar");
            Console.WriteLine("10. Keluar");
            Console.WriteLine("======================================");
            Console.Write("Pilih Menu (1, 2, 3, 4, 5, 6, 7, 8, 9, 10) : ");
            x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    InputdanOutput.LatihanInputOutput();
                    break;
                case "2":
                    InputdanOutput.LatihanOperasiAritmatika();
                    break;
                case "3":
                    InputdanOutput.LatihanKondisionalStatement();
                    break;
                case "4":
                    InputdanOutput.LatihanLoopingStatement();
                    break;
                case "5":
                    ArrayListCollection.Example1StringArrayLits();
                    break;
                case "6":
                    ArrayListCollection.Example2IntegerArrayLits();
                    break;
                case "7":
                    ListCollections.LatihanListCollection();
                    break;
                case "8":
                    GameTebakAngka.PermainanTebakAngka();
                    break;
                case "9":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Terimakasih, Sampai Jumpa Kembali...");
                    Console.WriteLine();
                    break;
            }

        } while (x != "10");

        Console.WriteLine("press any key...");
        Console.ReadKey();
    }
}
