using System.Configuration;
using System.Data.SqlClient;


namespace DataAccess
{
    public class DA
    {

        public string connectionString = string.Empty;
        public SqlConnection connection = new SqlConnection();

        public DA()
        {
            connectionString = "Server=tcp:inmobiliariajnvc.database.windows.net,1433;Initial Catalog=inmobiliariajnvc;Persist Security Info=False;User ID=leonel;Password=twyxnztcxW1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            connection = new SqlConnection(connectionString);

        }
    }

}
