using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Local
    {
        public int id {  get; set; }
        public string? zona { get; set; }
        public bool esDiafano {  get; set; }
        public float altilloAltura { get; set; }
        public bool vado { get; set; }
        public bool agua { get; set; }
        public bool luz { get; set; }
        public bool estaAcondicionado { get; set; }
        public int numeroPuertas { get; set; }
        public int id_inmueble { get; set; }
        public int Add()
        {
            try
            {
                string query = "insert into Locales (zona, es_diafano, altillo_altura, vado, agua, luz, esta_acondicionado, numero_puertas, id_inmueble) output inserted.id values (@zona, @es_diafano, @altillo_altura, @vado, @agua, @luz, @esta_acondicionado, @numero_puertas, @id_inmueble)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@zona", zona);
                cmd.Parameters.AddWithValue("@es_diafano", esDiafano);
                cmd.Parameters.AddWithValue("@altillo_altura", altilloAltura);
                cmd.Parameters.AddWithValue("@vado", vado);
                cmd.Parameters.AddWithValue("@agua", agua);
                cmd.Parameters.AddWithValue("@luz", luz);
                cmd.Parameters.AddWithValue("@esta_acondicionado", estaAcondicionado);
                cmd.Parameters.AddWithValue("@numero_puertas", numeroPuertas);
                cmd.Parameters.AddWithValue("id_inmueble", id_inmueble);

                return dbAccess.ExecuteAndGetID(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
