using System.Configuration;
using Microsoft.Data.SqlClient;
using Azure.Storage.Blobs;

namespace DataAccess
{
    public class DA
    {

        // Variables relacionadas con la conexión a la base de datos SQL
        public string connectionString = string.Empty;
        public SqlConnection connection = new SqlConnection();

        // Variables relacionadas con la conexión a Azure BLOB Storage
        public string imagePath = string.Empty;
        public string blobConnectionString = string.Empty;
        public string container = "estateimages";

        public DA()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DBString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            blobConnectionString = ConfigurationManager.ConnectionStrings["BLOBString"].ConnectionString;
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
        public int ExecuteAndGetID(SqlCommand cmd)
        {
            int idInsertado;
            try
            {
                connection.Open();
                cmd.Connection = connection;
                idInsertado = (int)cmd.ExecuteScalar();
                connection.Close();

                return idInsertado;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public string subirImagenAzure()
        {
            try
            {
                // Crear un cliente de blob para el contenedor
                BlobServiceClient blobServiceClient = new BlobServiceClient(blobConnectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(container);

                // Asegurarse de que el contenedor exista
                containerClient.CreateIfNotExists();

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(imagePath);

                // Crear un cliente para el blob
                BlobClient blobClient = containerClient.GetBlobClient(nombreArchivo);

                // Subir el archivo
                using (FileStream stream = File.OpenRead(imagePath))
                {
                    blobClient.Upload(stream, true);
                }

                // Devolver la URL pública del blob
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
