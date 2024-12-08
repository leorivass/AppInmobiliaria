using DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Visita
    {
        public int id { get; set; }
        public int id_inmueble { get; set; }
        public int id_cliente { get; set; }
        public string? comentario { get; set; }

        public void Add()
        {
            try
            {
                string query = "insert into Visitas (id_inmueble, id_cliente, comment, fecha, hora) values (@id_inmueble, @id_cliente, @comment, @fecha, @hora)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_inmueble", id_inmueble);
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("@comment", comentario);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@hora", DateTime.Now.TimeOfDay);

                dbAccess.ExecuteQuery(cmd);

                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CargarVisitas(DataGridView dataGridView1)
        {
            DataTable dat = new DataTable();
            try
            {

                string consulta = "SELECT v. id, v.id_inmueble, c.nombre AS nombre, c.telefono AS telefono, v.comment, v.fecha, v.hora FROM Visitas v INNER JOIN Cliente c ON v.id_cliente = c.id";
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

        public void DeleteVisita(int id)
        {
            try
            {
                string query = "DELETE FROM Visitas WHERE id = @id";


                DA db = new DA();

                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la visita: " + ex.Message, ex);
            }
        }

    }
}
