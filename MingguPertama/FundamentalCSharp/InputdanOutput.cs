using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public class InputdanOutput
    {
        public static void LatihanInputOutput()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Belajar Input dan Output");
            Console.WriteLine("========================");


            Console.Write("Ketikan inputan : ");
            string x = Console.ReadLine();
            Console.WriteLine("Output yang anda ketikan adalah : {0}", x);
        }

        public static void LatihanOperasiAritmatika()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Belajar Operasi Aritmatika");
            Console.WriteLine("==========================");

            Console.WriteLine("Hasil Penjumlahan String");
            PenjumlahanString("21", "12");

            #region Aritmatika Operasi
            //Console.WriteLine("Hasil Penjumlahan Integer");
            //PenjumlahanInteger(21, 12);

            //Console.WriteLine("Hasil Penjumlahan Integer");
            //PenguranganInteger(21, 12);

            //Console.WriteLine("Hasil Penjumlahan Integer");
            //PerkalianInteger(21, 12);

            //Console.WriteLine("Hasil Penjumlahan Integer");
            //PembagianInteger(21, 12);

            //Console.WriteLine("Hasil Penjumlahan Integer");
            //ModulusInteger(21, 12);
            #endregion
        }

        public static void LatihanKondisionalStatement()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Belajar Operasi Kondisional");
            Console.WriteLine("===========================");

            IfElseStatement(21, 12);

            #region Kondisional Operasi
            //IfElseIfStatement(21, 12);

            //SwitchCaseStatement(21);
            #endregion
        }

        public static void LatihanLoopingStatement()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Belajar Operasi Looping");
            Console.WriteLine("=======================");

            ForLoopStatement(21);

            #region Kondisional Operasi
            //DoWhileLoopStatement(21);

            //ForLoopStatement(21);
            #endregion
        }

        private static void PenjumlahanString(string x, string y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Console.ReadLine();

            Console.Write("Masukan Angka Ke-2 : ");
            y = Console.ReadLine();



            Console.WriteLine("Hasil Outputnya adalah : {0}", x + y);
        }

        private static void PenjumlahanInteger(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Hasil Outputnya adalah : {0}", x + y);
        }

        private static void PenguranganInteger(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Hasil Outputnya adalah : {0}", x - y);
        }

        private static void PerkalianInteger(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Hasil Outputnya adalah : {0}", x * y);
        }

        private static void PembagianInteger(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());

            double hasil = Convert.ToDouble(x) / Convert.ToDouble(y);

            Console.WriteLine("Hasil Outputnya adalah : {0}", hasil);
        }

        private static void ModulusInteger(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Hasil Outputnya adalah : {0}", x % y);
        }

        private static void IfElseStatement(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("Kondisi True");
                Console.WriteLine("Angka Ke-1 : {0} Lebih besar dari Angka Ke-2 : {1}", x, y);
            }
            //else
            //{
            //    Console.WriteLine("False");
            //    Console.WriteLine("Angka Ke-1 : {0} Lebih Kecil dari Angka Ke-2 : {1}", x, y);
            //}
        }

        private static void IfElseIfStatement(int x, int y)
        {
            Console.Write("Masukan Angka Ke-1 : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Angka Ke-2 : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("Angka Ke-1 : {0} Lebih besar dari Angka Ke-2 : {1}", x, y);
            }
            else if (x < y)
            {
                Console.WriteLine("Angka Ke-1 : {0} Lebih kecil dari Angka Ke-2 : {1}", x, y);
            }
            else if (x == y)
            {
                Console.WriteLine("Angka Ke-1 : {0} Sama Dengan Angka Ke-2 : {1}", x, y);
            }
            else if (x != y)
            {
                Console.WriteLine("Angka Ke-1 : {0} Tidak Sama Dengan Angka Ke-2 : {1}", x, y);
            }
            else
            {
                Console.WriteLine("Kondisi False");
                Console.WriteLine("Angka Ke-1 : {0} dan Angka Ke-2 : {1} tidak definisi", x, y);
            }
        }

        private static void SwitchCaseStatement(int x)
        {
            Console.Write("Masukan Nilai X : ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 2:
                    Console.WriteLine("Nilah X Sama dengan : {0}", x);
                    break;
                case 4:
                    Console.WriteLine("Nilah X Sama dengan : {0}", x);
                    break;
                case 6:
                    Console.WriteLine("Nilah X Sama dengan : {0}", x);
                    break;
                case 8:
                    Console.WriteLine("Nilah X Sama dengan : {0}", x);
                    break;
                case 10:
                    Console.WriteLine("Nilah X Sama dengan : {0}", x);
                    break;
                default:
                    Console.WriteLine("Nilah X Tidak Masuk dalam Case Statement : {0}", x);
                    break;
            }
        }

        private static void WhileLoopStatement(int x)
        {
            Console.Write("Masukan Nilai X : ");
            x = Convert.ToInt32(Console.ReadLine());

            while (x < 10)
            {
                Console.WriteLine("Nilah X adalah : {0}", x);

                x++;
            }
        }

        private static void DoWhileLoopStatement(int x)
        {
            Console.Write("Masukan Nilai X : ");
            x = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Nilah X adalah : {0}", x);

                x++;
            } while (x < 10);
        }

        private static void ForLoopStatement(int x)
        {
            Console.Write("Masukan Nilai X : ");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Nilah X {0} iterasi ke-{1}", x, i);
            }
        }
    }
}
