// See https://aka.ms/new-console-template for more information

using MemulaiDatabase.Helpers;
using MemulaiDatabase.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

public class Program
{
    static string connectionStrings = string.Empty;

    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var app = builder.Build();
        //ConstantsHelper connectionStrings = app.GetConnectionString("Bootcamp");
        connectionStrings = app.GetConnectionString("Bootcamp");
        string x = string.Empty;

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===================================================");
            Console.WriteLine("             Senang Belajar C Sharp(C#)            ");
            Console.WriteLine("     Latihan Fundamental Bahasa Pemrograman C#     ");
            Console.WriteLine("===================================================");
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine("Modul Modul Belajar Bhs. Pemrogram C#");
            Console.WriteLine("1. Tampilkan Data Dari Database");
            Console.WriteLine("2. Tampilkan Data Dari Database Berdasarkan Id");
            Console.WriteLine("3. Insert Data");
            Console.WriteLine("4. Update Data");
            Console.WriteLine("5. Hapus Data");
            Console.WriteLine("6. Bersihkan Layar");
            Console.WriteLine("7. Keluar");
            Console.WriteLine("======================================");
            Console.Write("Pilih Menu (1, 2, 3, 4, 5, 6, 7) : ");
            x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    GetDataMahasiswa(eventType: EventType.Retrive);
                    break;
                case "2":
                    Console.Write("Masukan Id Mahasiswa : ");
                    string idSearch = Console.ReadLine();
                    GetDataMahasiswaById(int.Parse(idSearch));
                    break;
                case "3":
                    Console.Write("Masukan NPP Mahasiswa : ");
                    string nppInsert = Console.ReadLine();

                    Console.Write("Masukan Nama Mahasiswa : ");
                    string namaInsert = Console.ReadLine();

                    Console.Write("Masukan Email Mahasiswa : ");
                    string emailInsert = Console.ReadLine();

                    Console.Write("Masukan Alamat Mahasiswa : ");
                    string alamatInsert = Console.ReadLine();

                    Console.Write("Masukan Jenis Kelamin Mahasiswa : ");
                    string jnsKelInsert = Console.ReadLine();
                    MahasiswaModel maInsert = new MahasiswaModel()
                    {
                        NPM = nppInsert,
                        NamaMahasiswa = namaInsert,
                        Email = emailInsert,
                        Alamat = alamatInsert,
                        JenisKelamin = jnsKelInsert
                    };

                    InsertDataMahasiswa(maInsert);
                    break;
                case "4":
                    MahasiswaModel maUpdate = new MahasiswaModel();
                    string pil = string.Empty;

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("=====================================");
                        Console.WriteLine("Pilih Aksi Untuk Meng-Update data");
                        Console.WriteLine("1. Update All");
                        Console.WriteLine("2. Update Nomor Pokok Mahasiswa(NPM)");
                        Console.WriteLine("3. Update Nama");
                        Console.WriteLine("4. Update Email");
                        Console.WriteLine("5. Alamat");
                        Console.WriteLine("6. Jenis Kelamin");
                        Console.WriteLine("7. Keluar");
                        Console.WriteLine("======================================");
                        Console.Write("Pilih Menu (1, 2, 3, 4, 5, 6, 7) : ");
                        pil = Console.ReadLine();
                        if (pil == "1")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan NPP Mahasiswa : ");
                            string nppUpdate = Console.ReadLine();

                            Console.Write("Masukan Nama Mahasiswa : ");
                            string namaUpdate = Console.ReadLine();

                            Console.Write("Masukan Email Mahasiswa : ");
                            string emailUpdate = Console.ReadLine();

                            Console.Write("Masukan Alamat Mahasiswa : ");
                            string alamatUpdate = Console.ReadLine();

                            Console.Write("Masukan Jenis Kelamin Mahasiswa : ");
                            string jnsKelUpdate = Console.ReadLine();


                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.NPM = nppUpdate;
                            maUpdate.NamaMahasiswa = namaUpdate;
                            maUpdate.Email = emailUpdate;
                            maUpdate.Alamat = alamatUpdate;
                            maUpdate.JenisKelamin = jnsKelUpdate;
                        }
                        else if(pil == "2")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan NPP Mahasiswa : ");
                            string nppUpdate = Console.ReadLine();
                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.NPM = nppUpdate;

                            UpdateDataMahasiswa(maUpdate, ForUpdate.NPM);
                        }
                        else if (pil == "3")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan Nama Mahasiswa : ");
                            string namaUpdate = Console.ReadLine();
                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.NamaMahasiswa = namaUpdate;

                            UpdateDataMahasiswa(maUpdate, ForUpdate.Nama);
                        }
                        else if (pil == "4")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan Email Mahasiswa : ");
                            string emailUpdate = Console.ReadLine();

                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.Email = emailUpdate;

                            UpdateDataMahasiswa(maUpdate, ForUpdate.Email);
                        }
                        else if (pil == "5")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan Alamat Mahasiswa : ");
                            string alamatUpdate = Console.ReadLine();

                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.Alamat = alamatUpdate;

                            UpdateDataMahasiswa(maUpdate, ForUpdate.Alamat);
                        }
                        else if (pil == "6")
                        {
                            Console.Write("Masukan Id Mahasiswa : ");
                            string idUpdate = Console.ReadLine();

                            Console.Write("Masukan Jenis Kelamin Mahasiswa : ");
                            string jnsKelUpdate = Console.ReadLine();

                            maUpdate.Id = int.Parse(idUpdate);
                            maUpdate.JenisKelamin = jnsKelUpdate;

                            UpdateDataMahasiswa(maUpdate, ForUpdate.JnsKelamin);
                        }
                    } while (pil != "7");
                    break;
                case "5":
                    Console.Write("Masukan Id Mahasiswa : ");
                    string idDelete = Console.ReadLine();
                    DeleteDataMahasiswa(int.Parse(idDelete));
                    break;
                case "6":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error : Pilihan anda tidak sesuai. Silahkan Pilih menu kembali");
                    break;
            }

        } while (x != "7");
    }

    private static void GetDataMahasiswa(EventType eventType)
    {
        MahasiswaModel model = new MahasiswaModel();
        SqlConnection connection = GetConnection(connectionStrings);
        SqlCommand command = new SqlCommand("SELECT * FROM Mahasiswa Where IsActive = 1", connection);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                switch (eventType)
                {
                    case EventType.Retrive:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case EventType.Insert:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case EventType.Update:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case EventType.Delete:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                Console.WriteLine("======================================================================");
                Console.WriteLine("=                            Data Mahasiswa                          =");
                Console.WriteLine("======================================================================");

                while (reader.Read())
                {
                    model.Id = Convert.ToInt32(reader["Id"]);
                    model.NPM = reader["NPM"].ToString();
                    model.NamaMahasiswa = reader["NamaMahasiswa"].ToString();
                    model.Email = reader["Email"].ToString();
                    model.Alamat = reader["Alamat"].ToString();
                    model.JenisKelamin = reader["JenisKelamin"].ToString();

                    //Console.WriteLine();
                    Console.WriteLine($"Id Mahasiswa                            : {model.Id}");
                    Console.WriteLine($"Nomor Pokok Mahasiswa(NPM)              : {model.NPM}");
                    Console.WriteLine($"Nama Mahasiswa                          : {model.NamaMahasiswa}");
                    Console.WriteLine($"Email Address                           : {model.Email}");
                    Console.WriteLine($"ALamat                                  : {model.Alamat}");
                }

                Console.WriteLine("======================================================================");
                Console.WriteLine("=                            End Mahasiswa                           =");
                Console.WriteLine("======================================================================");
                Console.WriteLine();
            }

            connection.Close();
        }
    }

    private static void GetDataMahasiswaById(int idMhs)
    {
        MahasiswaModel model = new MahasiswaModel();
        SqlConnection connection = GetConnection(connectionStrings);
        SqlCommand command = new SqlCommand("SELECT * FROM Mahasiswa WHERE Id = @p_IdMhs AND IsActive <> 0", connection);
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@p_IdMhs", idMhs);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("======================================================================");
                Console.WriteLine("=                            Data Mahasiswa                          =");
                Console.WriteLine("======================================================================");

                while (reader.Read())
                {
                    model.Id = Convert.ToInt32(reader["Id"]);
                    model.NPM = reader["NPM"].ToString();
                    model.NamaMahasiswa = reader["NamaMahasiswa"].ToString();
                    model.Email = reader["Email"].ToString();
                    model.Alamat = reader["Alamat"].ToString();
                    model.JenisKelamin = reader["JenisKelamin"].ToString();

                    //Console.WriteLine();
                    Console.WriteLine($"Id Mahasiswa                            : {model.Id}");
                    Console.WriteLine($"Nomor Pokok Mahasiswa(NPM)              : {model.NPM}");
                    Console.WriteLine($"Nama Mahasiswa                          : {model.NamaMahasiswa}");
                    Console.WriteLine($"Email Address                           : {model.Email}");
                    Console.WriteLine($"ALamat                                  : {model.Alamat}");
                    Console.WriteLine($"Jenis Kelamain                          : {model.JenisKelamin}");
                }

                Console.WriteLine("======================================================================");
                Console.WriteLine("=                            End Mahasiswa                           =");
                Console.WriteLine("======================================================================");
                Console.WriteLine();
            }

            connection.Close();
        }
    }

    private static void InsertDataMahasiswa(MahasiswaModel model)
    {
        try
        {
            SqlConnection connection = GetConnection(connectionStrings);
            SqlCommand command = new SqlCommand(@"INSERT INTO MAHASISWA 
                                            (NPP, NamaMahasiswa, Email, ALamat, JenisKelamin) 
                                            VALUES 
                                            (@p_Npp, @p_NamaMahasiswa, @p_Email, @p_ALamat, @p_JenisKelamin)", connection);

            command.Parameters.AddWithValue("@p_Npp", model.NPM);
            command.Parameters.AddWithValue("@p_NamaMahasiswa", model.NamaMahasiswa);
            command.Parameters.AddWithValue("@p_Email", model.Email);
            command.Parameters.AddWithValue("@p_ALamat", model.Alamat);
            command.Parameters.AddWithValue("@p_JenisKelamin", model.JenisKelamin);
            int cmdCount = command.ExecuteNonQuery();
            if (cmdCount > 0)
            {
                Console.WriteLine($"Berhasil Insert Ke database");

                GetDataMahasiswa(eventType: EventType.Insert);
            }
            else
            {
                Console.WriteLine($"Gagal Insert ke database");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private static void UpdateDataMahasiswa(MahasiswaModel model, ForUpdate forUpdate)
    {
        try
        {
            SqlConnection connection = GetConnection(connectionStrings);
            switch (forUpdate)
            {
                case ForUpdate.NPM:
                    SqlCommand commandNpp = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET NPP = @p_Npp
                                                    WHERE Id = @p_IdMhs", connection);

                    commandNpp.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandNpp.Parameters.Add("@p_Npp", System.Data.SqlDbType.VarChar).Value = (object)model.NPM ?? DBNull.Value;

                    int cmdCountNpp = commandNpp.ExecuteNonQuery();
                    if (cmdCountNpp > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Nomor Pokok Mahasiswa(NPM) Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
                case ForUpdate.Nama:
                    SqlCommand commandNama = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET NamaMahasiswa = @p_NamaMahasiswa
                                                    WHERE Id = @p_IdMhs", connection);

                    commandNama.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandNama.Parameters.Add("@p_NamaMahasiswa", System.Data.SqlDbType.VarChar).Value = (object)model.NamaMahasiswa ?? DBNull.Value;

                    int cmdCountNama = commandNama.ExecuteNonQuery();
                    if (cmdCountNama > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Nama Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
                case ForUpdate.Email:
                    SqlCommand commandEmail = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET Email = @p_Email
                                                    WHERE Id = @p_IdMhs", connection);

                    commandEmail.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandEmail.Parameters.Add("@p_Email", System.Data.SqlDbType.VarChar).Value = (object)model.Email ?? DBNull.Value;

                    int cmdCountEmail = commandEmail.ExecuteNonQuery();
                    if (cmdCountEmail > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Email Address Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
                case ForUpdate.Alamat:
                    SqlCommand commandAlamat = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET ALamat = @p_ALamat
                                                    WHERE Id = @p_IdMhs", connection);

                    commandAlamat.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandAlamat.Parameters.Add("@p_ALamat", System.Data.SqlDbType.VarChar).Value = (object)model.Alamat ?? DBNull.Value;

                    int cmdCountAlamat = commandAlamat.ExecuteNonQuery();
                    if (cmdCountAlamat > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Alamat Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
                case ForUpdate.JnsKelamin:
                    SqlCommand commandJnsKel = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET JenisKelamin = @p_JenisKelamin
                                                    WHERE Id = @p_IdMhs", connection);

                    commandJnsKel.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandJnsKel.Parameters.Add("@p_JenisKelamin", System.Data.SqlDbType.VarChar).Value = (object)model.JenisKelamin ?? DBNull.Value;

                    int cmdCountJnsKel = commandJnsKel.ExecuteNonQuery();
                    if (cmdCountJnsKel > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Jenis Kelamin Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
                default:
                    SqlCommand commandAll = new SqlCommand(@$"UPDATE MAHASISWA
                                                    SET NPP = @p_Npp,
                                                        NamaMahasiswa = @p_NamaMahasiswa,
                                                        Email = @p_Email,
                                                        ALamat = @p_ALamat,
                                                        JenisKelamin = @p_JenisKelamin
                                                    WHERE Id = @p_IdMhs", connection);

                    commandAll.Parameters.Add("@p_IdMhs", System.Data.SqlDbType.Int).Value = model.Id;
                    commandAll.Parameters.Add("@p_Npp", System.Data.SqlDbType.VarChar).Value = (object)model.NPM ?? DBNull.Value;
                    commandAll.Parameters.Add("@p_NamaMahasiswa", System.Data.SqlDbType.VarChar).Value = (object)model.NamaMahasiswa ?? DBNull.Value;
                    commandAll.Parameters.Add("@p_Email", System.Data.SqlDbType.VarChar).Value = (object)model.Email ?? DBNull.Value;
                    commandAll.Parameters.Add("@p_ALamat", System.Data.SqlDbType.VarChar).Value = (object)model.Alamat ?? DBNull.Value;
                    commandAll.Parameters.Add("@p_JenisKelamin", System.Data.SqlDbType.VarChar).Value = (object)model.JenisKelamin ?? DBNull.Value;

                    int cmdCountAll = commandAll.ExecuteNonQuery();
                    if (cmdCountAll > 0)
                    {
                        Console.WriteLine($"Berhasil Update Data Ke database");

                        GetDataMahasiswa(eventType: EventType.Update);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"Gagal Update Data ke database");
                    }
                    break;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private static void DeleteDataMahasiswa(int idMhs)
    {
        try
        {
            SqlConnection connection = GetConnection(connectionStrings);
            SqlCommand command = new SqlCommand(@"UPDATE MAHASISWA SET IsActive = 0 WHERE Id = @p_IdMhs", connection);

            command.Parameters.AddWithValue("@p_IdMhs", idMhs);
            int cmdCount = command.ExecuteNonQuery();
            if (cmdCount > 0)
            {
                Console.WriteLine($"Berhasil Hapus Data Mahasiswa Ke database");

                GetDataMahasiswa(eventType: EventType.Delete);
            }
            else
            {
                Console.WriteLine($"Gagal Hapus Data Mahasiswa ke database");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private static SqlConnection GetConnection(string connString)
    {
        SqlConnection sqlConnection = null;

        try
        {
            sqlConnection = new SqlConnection(connString);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return sqlConnection;
    }
}

public enum EventType
{
    Retrive,
    Insert,
    Update,
    Delete,
    Default
}

public enum ForUpdate
{
    NPM,
    Nama,
    Email,
    Alamat,
    JnsKelamin,
    All
}
