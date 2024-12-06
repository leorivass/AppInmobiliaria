using System.Configuration;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class DA
    {

        public string connectionString = string.Empty;
        public SqlConnection connection = new SqlConnection();

        public DA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public SqlDataReader GetConsult(SqlCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ExecuteQuery(SqlCommand cmd)
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();

                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
