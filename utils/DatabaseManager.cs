using System.Data.SqlClient;

namespace MinecraftManager.Utils
{
    public class DatabaseManager
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-MC98NOL\SQLEXPRESS;Initial Catalog=ProyectoParcial2;Integrated Security=True;TrustServerCertificate=True";


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
