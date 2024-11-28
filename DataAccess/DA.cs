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
    }
}
