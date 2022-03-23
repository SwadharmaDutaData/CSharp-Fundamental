using MemulaiDatabase.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemulaiDatabase.Data
{
    public class DataConfiguration
    {
        private static SqlConnection connection = GetConnection(ConstantsHelper.CONNECTION_STRING);
        SqlCommand command = new SqlCommand("SELECT * FROM Mahasiswa", connection);

        public static SqlConnection GetConnection(string connString)
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

        public static SqlCommand GetCommand(string commandText, SqlConnection connection, ExecuteCommand execute, SqlParameter[] parameters = null)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand = new SqlCommand(commandText, connection);
                if (parameters != null)
                {
                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddRange(parameters);
                    switch (execute)
                    {
                        case ExecuteCommand.ExecuteNonQuery:
                            sqlCommand.ExecuteNonQuery();
                            break;
                        case ExecuteCommand.ExecuteReader:
                            sqlCommand.ExecuteReader();
                            break;
                        case ExecuteCommand.ExecuteScalar:
                            sqlCommand.ExecuteScalar();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (execute)
                    {
                        case ExecuteCommand.ExecuteNonQuery:
                            sqlCommand.ExecuteNonQuery();
                            break;
                        case ExecuteCommand.ExecuteReader:
                            sqlCommand.ExecuteReader();
                            break;
                        case ExecuteCommand.ExecuteScalar:
                            sqlCommand.ExecuteScalar();
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return sqlCommand;
        }
    }

    public enum ExecuteCommand
    {
        ExecuteNonQuery,
        ExecuteReader,
        ExecuteScalar
    }
}
