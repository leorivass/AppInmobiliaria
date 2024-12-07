using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class Casa
    {
        public int id {  get; set; }
        public string? zona { get; set; }
        public int id_vivienda {  get; set; }

        public int Add()
        {
            try
            {
                string query = "insert into Casa (zona, id_vivienda) output inserted.id values (@zona, @id_vivienda)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@zona", zona);
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
