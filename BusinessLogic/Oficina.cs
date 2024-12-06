using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic
{
    public class Oficina
    {
        public string? ubicacion { get; set; }
        public string? telefono { get; set; }

        public void Add()
        {
            try
            {
                string query = "insert into Oficina (ubicacion, telefono) values (@ubicacion, @telefono)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                dbAccess.ExecuteQuery(cmd);

                return;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool DoesThisOfficeExist()
        {
            try
            {
                string query = "select ubicacion, telefono from Oficina where ubicacion=@ubicacion and telefono=@telefono";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                SqlDataReader reader = dbAccess.GetConsult(cmd);

                if (reader.HasRows) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
