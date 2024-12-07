using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Piso
    {
        public int id { get; set; }
        public string? zona { get; set; }
        public bool nuevo { get; set; }
        public bool ocasion { get; set; }
        public int id_vivienda { get; set; }

        public int Add()
        {
            try
            {
                string query = "insert into Piso (zona, nuevo, ocasion, id_vivienda) output inserted.id values (@zona, @nuevo, @ocasion, @id_vivienda)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@zona", zona);
                cmd.Parameters.AddWithValue("@nuevo", nuevo);
                cmd.Parameters.AddWithValue("@ocasion", ocasion);
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
