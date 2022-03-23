using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public class GameTebakAngka
    {
        private static Random systemGame = new Random();
        private static Random comPlayer = new Random();
        public static void PermainanTebakAngka()
        {
            string x = string.Empty; ;

            do
            {
                Console.WriteLine("===================");
                Console.WriteLine("Bermain Tebak Angka");
                Console.WriteLine("1. Single");
                Console.WriteLine("2. Multiplayer");
                Console.WriteLine("3. Bersihkan Layar");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("===================");
                Console.Write("Pilih Menu (1, 2, 3, 4) : ");
                x = Console.ReadLine();

                int generateNum = systemGame.Next(1, 9);
                int playerComputer = comPlayer.Next(1, 9);

                switch (x)
                {
                    case "1":
                        string sd = string.Empty;

                        do
                        {
                            Console.Write("Masukan Angka : ");
                            int user = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (generateNum == user)
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"Player Computer Menebak Angka : {playerComputer}");
                                Console.WriteLine($"Anda Menebank Angka : {user}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan Anda Benar!!!");
                                Console.WriteLine();
                            }
                            else if (generateNum == playerComputer)
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"Player Computer Menebak Angka : {playerComputer}");
                                Console.WriteLine($"Anda Menebank Angka : {user}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan Computer Benar!!!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"Player Computer Menebak Angka : {playerComputer}");
                                Console.WriteLine($"Anda Menebank Angka : {user}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan Anda Salah Semua");
                                Console.WriteLine();
                            }

                            Console.Write("Ingin Bermain Lagi(Y/N)? ");
                            sd = Console.ReadLine();
                        } while (sd == "n" || sd == "N");
                        break;
                    case "2":
                        string zx = string.Empty;

                        do
                        {
                            Console.Write("User 1 Masukan Angka : ");
                            int user1 = int.Parse(Console.ReadLine());

                            Console.Write("User 2 Masukan Angka : ");
                            int user2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (generateNum == user1)
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"User 1 Menebak Angka : {user1}");
                                Console.WriteLine($"User 2 Menebak Angka : {user2}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan User 1 Benar!!!");
                                Console.WriteLine();
                            }
                            else if (generateNum == user2)
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"User 1 Menebak Angka : {user1}");
                                Console.WriteLine($"User 2 Menebak Angka : {user2}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan User 2 Benar!!!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine($"System Membuat Angka : {generateNum}");
                                Console.WriteLine($"User 1 Menebak Angka : {user1}");
                                Console.WriteLine($"User 2 Menebak Angka : {user2}");
                                Console.WriteLine();
                                Console.WriteLine("Tebakan Anda Salah Semua!!!");
                                Console.WriteLine();
                            }

                            Console.Write("Ingin Bermain Lagi(Y/N)? ");
                            zx = Console.ReadLine();
                        } while (zx != "n" || zx != "N");
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (x != "4");
        }
    }
}
