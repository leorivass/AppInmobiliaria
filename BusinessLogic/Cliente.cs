
using DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class Cliente
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? telefono { get; set; }
        public string? correo { get; set; }
        public string? cedula { get; set; }

        public void Add()
        {
            try
            {
                string query = "insert into Cliente (nombre, telefono, correo, cedula) values (@nombre, @telefono, @correo, @cedula)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@cedula", cedula);

                dbAccess.ExecuteQuery(cmd);

                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool DoesThisClientExist()
        {
            try
            {
                string query = "select cedula from Cliente where cedula=@cedula";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@cedula", cedula);

                SqlDataReader reader = dbAccess.GetConsult(cmd);

                if (reader.HasRows)
                {
                    dbAccess.connection.Close();
                    return true;
                }
                else
                {
                    dbAccess.connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int? GetID()
        {
            try
            {
                string query = "select id from Cliente where nombre=@nombre and telefono=@telefono";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                SqlDataReader reader = dbAccess.GetConsult(cmd);

                if (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    dbAccess.connection.Close();
                    return ID;
                }
                else
                {
                    dbAccess.connection.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select id, concat(nombre, ', ', cedula) as descripcion from Cliente";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;

                SqlDataReader reader = dbAccess.GetConsult(cmd);
                dt.Load(reader);

                dbAccess.connection.Close();

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CargarClientes(DataGridView dataGridView1)
        {
            DataTable dat = new DataTable();
            try
            {

                string consulta = "select * from Cliente";
                DA db = new DA();
                db.connection.Open();
                SqlCommand command = new SqlCommand(consulta, db.connection);
                SqlDataReader reader = command.ExecuteReader();
                dat.Load(reader);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dat;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void DeleteCliente(int id)
        {
            try
            {
                string query = "DELETE FROM Cliente WHERE id = @id";


                DA db = new DA();

                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message, ex);
            }
        }
        public static void EditCliente(int id, string nombre, string telefono, string correo, string cedula)
        {
            try
            {
                string query = "UPDATE Cliente SET nombre = @nombre, telefono = @telefono, correo = @correo, cedula = @cedula WHERE id = @id";
                DA db = new DA();

                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el cliente: " + ex.Message, ex);
            }
        }
    }

}

