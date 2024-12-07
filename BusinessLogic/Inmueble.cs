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
    public class Inmueble
    {
        public int? id_oficina { get; set; }
        public int? id_propietario { get; set; }
        public float precio_venta { get; set; }
        public float precio_alquiler { get; set; }
        public string? direccion { get; set; }
        public float metros_cuadrados { get; set; }
        public string? ruta_foto { get; set; }
        public int REF { get; set; }

        public int Add()
        {
            try
            {
                string query = "insert into Inmueble (id_oficina, id_propietario, precio_venta, precio_alquiler, direccion, metros_cuadrados, ruta_foto) output inserted.id values (@id_oficina, @id_propietario, @precio_venta, @precio_alquiler, @direccion, @metros_cuadrados, @ruta_foto)";

                DA dbAccess = new DA();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id_oficina", id_oficina);
                cmd.Parameters.AddWithValue("@id_propietario", id_propietario);
                cmd.Parameters.AddWithValue("@precio_venta", precio_venta);
                cmd.Parameters.AddWithValue("@precio_alquiler", precio_alquiler);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@metros_cuadrados", metros_cuadrados);
                cmd.Parameters.AddWithValue("@ruta_foto", ruta_foto);

                return dbAccess.ExecuteAndGetID(cmd);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
