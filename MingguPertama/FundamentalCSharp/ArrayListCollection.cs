using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public class ArrayListCollection
    {
        public static void Example1StringArrayLits()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Latihan String Array List");
            Console.WriteLine("=========================");

            string[] arrName = new string[] { "Budi", "Maya", "Fatan", "Jhon Doe", "Mellany" };
            string[] result = arrName;
            string[] arrresult = null;
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
                    string[] tempResult = null;
                    //string[] temp = tempResult;

                    if (result.Length == 5)
                    {
                        result = arrName.Append(c).ToArray();

                        LoadArrayList(ref result);
                    }
                    else
                    {
                        arrresult = result;
                        arrresult = arrresult.Append(c).ToArray();
                        string[] temp = arrresult;

                        LoadArrayList(ref temp);
                        result = arrresult;
                    }
                }
                else if (x == "2")
                {
                    Console.Write("Ingin Hapus Nomor : ");
                    int c = int.Parse(Console.ReadLine());

                    result = result.Where((source, index) => index != c - 1).ToArray();

                    LoadArrayList(ref result);
                }
                else if (x == "3")
                {
                    LoadArrayList(ref result);
                }
                else if (x == "4")
                {
                    Console.Clear();
                }
            } while (x != "5");
        }

        public static void Example2IntegerArrayLits()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Latihan Integer Array List");
            Console.WriteLine("==========================");

            int[] arrNum = { 1, 2, 3, 4, 5 };
            int[] result = arrNum;
            int[] arrresult = null;
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
                    Console.Write("Tambah Integer Number : ");
                    int c = int.Parse(Console.ReadLine());
                    string[] tempResult = null;
                    //string[] temp = tempResult;

                    if (result.Length == 5)
                    {
                        result = arrNum.Append(c).ToArray();

                        LoadArrayList(ref result);
                    }
                    else
                    {
                        arrresult = result;
                        arrresult = arrresult.Append(c).ToArray();
                        int[] temp = arrresult;

                        LoadArrayList(ref temp);
                        result = arrresult;
                    }
                }
                else if (x == "2")
                {
                    Console.Write("Ingin Hapus Nomor : ");
                    int c = int.Parse(Console.ReadLine());

                    result = result.Where((source, index) => index != c - 1).ToArray();

                    LoadArrayList(ref result);
                }
                else if (x == "3")
                {
                    LoadArrayList(ref result);
                }
                else if (x == "4")
                {
                    LoadArrayList(ref result);
                }
            } while (x != "5");
        }

        private static void LoadArrayList(ref string[] arr)
        {
            int number = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"No {number++}. " + arr[i]);
            }
        }

        private static void LoadArrayList(ref int[] arr)
        {
            int number = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"No {number++}. " + arr[i]);
            }
        }
    }
}
