using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Villa
    {
        public int id { get; set; }
        public float parcela { get; set; }
        public string? urbanizacion { get; set; }
        public int id_vivienda { get; set; }

        public int Add()
        {
            try
            {
                string query = "insert into Villa (parcela, urbanizacion, id_vivienda) output inserted.id values (@parcela, @urbanizacion, @id_vivienda)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@parcela", parcela);
                cmd.Parameters.AddWithValue("@urbanizacion", urbanizacion);
                cmd.Parameters.AddWithValue("@id_vivienda", id_vivienda);

                return dbAccess.ExecuteAndGetID(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
