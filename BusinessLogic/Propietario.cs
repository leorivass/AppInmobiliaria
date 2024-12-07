using DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class Propietario
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
                string query = "insert into Propietario (nombre, telefono, correo, cedula) values (@nombre, @telefono, @correo, @cedula)";

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

        public bool DoesThisOwnerExist()
        {
            try
            {
                string query = "select cedula from Propietario where cedula=@cedula";

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
                string query = "select id from Propietario where nombre=@nombre and telefono=@telefono";

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

        public DataTable GetAllOwners()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select concat(nombre, ', ', cedula) as descripcion from Propietario";

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
        public void CargarPropietarios(DataGridView propietariosGridView)
        {
            DataTable dat = new DataTable();
            try
            {

                string consulta = "select * from Propietario";
                DA db = new DA();
                db.connection.Open();
                SqlCommand command = new SqlCommand(consulta, db.connection);
                SqlDataReader reader = command.ExecuteReader();
                dat.Load(reader);
                propietariosGridView.AutoGenerateColumns = true;
                propietariosGridView.DataSource = dat;
                reader.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
