using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Vivienda
    {
        public int id { get; set; }
        public int habitaciones { get; set; }
        public int baños { get; set; }
        public bool salon { get; set; }
        public int armarios { get; set; }
        public float m2_terraza { get; set; }
        public bool garaje { get; set; }
        public bool gas { get; set; }
        public bool calefaccion { get; set; }
        public int id_inmueble { get; set; }

        public int Add()
        {
            try
            {
                string query = "insert into Vivienda (habitaciones, baños, salon, armarios, m2_terraza, garaje, gas, calefaccion, id_inmueble) output inserted.id values (@habitaciones, @baños, @salon, @armarios, @m2_terraza, @garaje, @gas, @calefaccion, @id_inmueble)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@habitaciones", habitaciones);
                cmd.Parameters.AddWithValue("@baños", baños);
                cmd.Parameters.AddWithValue("@salon", salon);
                cmd.Parameters.AddWithValue("@armarios", armarios);
                cmd.Parameters.AddWithValue("@m2_terraza", m2_terraza);
                cmd.Parameters.AddWithValue("@garaje", garaje);
                cmd.Parameters.AddWithValue("@gas", gas);
                cmd.Parameters.AddWithValue("@calefaccion", calefaccion);
                cmd.Parameters.AddWithValue("@id_inmueble", id_inmueble);

                return dbAccess.ExecuteAndGetID(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
