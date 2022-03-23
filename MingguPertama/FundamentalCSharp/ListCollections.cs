using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public class ListCollections
    {
        public static void LatihanListCollection()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Belajar List Collections");
            Console.WriteLine("========================");


            List<string> list = new List<string>()
            {
                "Andi",
                "Maya",
                "Bintang",
                "Karin",
                "Nisa"
            };
            string x = string.Empty;

            do
            {
                Console.WriteLine("===============");
                Console.WriteLine("Menu Array Name");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Hapus");
                Console.WriteLine("3. Tampilkan");
                Console.WriteLine("4. Bersihkan Layar");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("===============");

                Console.Write("Pilih Menu (1, 2, 3, 4, 5) : ");
                x = Console.ReadLine();

                if (x == "1")
                {
                    Console.Write("Tambah Nama : ");
                    string? c = Console.ReadLine();
                    list.Add(c);
                    ForeachLoopStatement(ref list);
                }
                else if (x == "2")
                {
                    Console.Write("Ingin Hapus Nomor : ");
                    int c = int.Parse(Console.ReadLine());
                    list.RemoveAt(c - 1);
                    ForeachLoopStatement(ref list);
                }
                else if (x == "3")
                {
                    ForeachLoopStatement(ref list);
                }
                else if (x == "4")
                {
                    Console.Clear();
                }
            } while (x != "5");
        }

        private static void ForeachLoopStatement(ref List<string> list)
        {
            int counter = 1;
            foreach (var item in list)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
        }
    }
}
