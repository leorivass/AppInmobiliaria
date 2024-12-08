using Microsoft.Data.SqlClient;
using DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public class PropiedadCompleta
    {
        public string? propietario { get; set; }
        public string? oficina { get; set; }

        // Atributos para vivienda
        public int idInmueble { get; set; }
        public string? tipo { get; set; }
        public decimal? precioVenta { get; set; }
        public decimal? precioAlquiler { get; set; }
        public string? direccion { get; set; }
        public decimal metrosCuadrados { get; set; }
        public string? imagenUrl { get; set; }
        public int? habitaciones { get; set; }
        public int? baños { get; set; }
        public bool? salon { get; set; }
        public int? armarios { get; set; }
        public decimal? terraza { get; set; }
        public bool? garaje { get; set; }
        public bool? gas { get; set; }
        public bool? calefaccion { get; set; }
        public string? zona { get; set; }
        public string? parcela { get; set; }

        // Atributos para local
        public bool? esDiafano { get; set; }
        public decimal? altilloAltura { get; set; }
        public bool? vado { get; set; }
        public bool? agua { get; set; }
        public bool? luz { get; set; }
        public bool? estaAcondicionado { get; set; }
        public int? numeroPuertas { get; set; }

        public List<PropiedadCompleta> GetPropertyData(int idOficina)
        {
            List<PropiedadCompleta> propiedades = new List<PropiedadCompleta>();

            string query = @"
                SELECT 
                    i.id AS IdInmueble, 
                    c.id AS IdPropiedad, 
                    'Casa' AS Tipo,
                    i.precio_venta, 
                    i.precio_alquiler, 
                    i.direccion, 
                    i.metros_cuadrados, 
                    i.ruta_foto AS ImagenUrl,
                    v.habitaciones, 
                    v.baños, 
                    v.salon, 
                    v.armarios, 
                    v.m2_terraza AS Terrazas, 
                    v.garaje, 
                    v.gas, 
                    v.calefaccion,
                    c.zona AS Zona, -- Cambiado a Zona
                    NULL AS Parcela, -- No aplica para Casa
                    p.nombre AS NombrePropietario,
                    o.ubicacion AS NombreOficina,
                    NULL As Agua, -- Aplica solo para Locales
                    NULL AS EsDiafano, -- No aplica para Casa
                    NULL AS AltilloAltura, -- No aplica para Casa
                    NULL AS Vado, -- No aplica para Casa
                    NULL AS EstaAcondicionado, -- No aplica para Casa
                    NULL AS NumeroPuertas, -- No aplica para Casa
                    NULL AS Luz
                FROM 
                    Casa c
                JOIN 
                    Vivienda v ON c.id_vivienda = v.id
                JOIN 
                    Inmueble i ON v.id_inmueble = i.id
                JOIN 
                    Propietario p ON i.id_propietario = p.id
                JOIN 
                    Oficina o ON i.id_oficina = o.id
                WHERE 
                    i.id_oficina = @idOficina

                UNION

                SELECT 
                    i.id AS IdInmueble, 
                    p.id AS IdPropiedad, 
                    'Piso' AS Tipo,
                    i.precio_venta, 
                    i.precio_alquiler, 
                    i.direccion, 
                    i.metros_cuadrados, 
                    i.ruta_foto AS ImagenUrl,
                    v.habitaciones, 
                    v.baños, 
                    v.salon, 
                    v.armarios, 
                    v.m2_terraza AS Terrazas, 
                    v.garaje, 
                    v.gas, 
                    v.calefaccion,
                    p.zona AS Zona, -- Cambiado a Zona
                    NULL AS Parcela, -- No aplica para Piso
                    pr.nombre AS NombrePropietario,
                    o.ubicacion AS NombreOficina,
                    NULL As Agua, -- Aplica solo para Locales
                    NULL AS EsDiafano, -- No aplica para Piso
                    NULL AS AltilloAltura, -- No aplica para Piso
                    NULL AS Vado, -- No aplica para Piso
                    NULL AS EstaAcondicionado, -- No aplica para Piso
                    NULL AS NumeroPuertas, -- No aplica para Piso
                    NULL AS Luz
                FROM 
                    Piso p
                JOIN 
                    Vivienda v ON p.id_vivienda = v.id
                JOIN 
                    Inmueble i ON v.id_inmueble = i.id
                JOIN 
                    Propietario pr ON i.id_propietario = pr.id
                JOIN 
                    Oficina o ON i.id_oficina = o.id
                WHERE 
                    i.id_oficina = @idOficina

                UNION

                SELECT 
                    i.id AS IdInmueble, 
                    vv.id AS IdPropiedad, 
                    'Villa' AS Tipo,
                    i.precio_venta, 
                    i.precio_alquiler, 
                    i.direccion, 
                    i.metros_cuadrados, 
                    i.ruta_foto AS ImagenUrl,
                    v.habitaciones, 
                    v.baños, 
                    v.salon, 
                    v.armarios, 
                    v.m2_terraza AS Terrazas, 
                    v.garaje, 
                    v.gas, 
                    v.calefaccion,
                    vv.urbanizacion AS Zona, -- Cambiado a Zona
                    vv.parcela AS Parcela, -- Aplica para Villa
                    pr.nombre AS NombrePropietario,
                    o.ubicacion AS NombreOficina,
                    NULL As Agua, -- Aplica solo para Locales
                    NULL AS EsDiafano, -- No aplica para Villa
                    NULL AS AltilloAltura, -- No aplica para Villa
                    NULL AS Vado, -- No aplica para Villa
                    NULL AS EstaAcondicionado, -- No aplica para Villa
                    NULL AS NumeroPuertas, -- No aplica para Villa
                    NULL AS Luz
                FROM 
                    Villa vv
                JOIN 
                    Vivienda v ON vv.id_vivienda = v.id
                JOIN 
                    Inmueble i ON v.id_inmueble = i.id
                JOIN 
                    Propietario pr ON i.id_propietario = pr.id
                JOIN 
                    Oficina o ON i.id_oficina = o.id
                WHERE 
                    i.id_oficina = @idOficina

                UNION

                SELECT 
                    i.id AS IdInmueble, 
                    l.id AS IdPropiedad, 
                    'Local' AS Tipo,
                    i.precio_venta, 
                    i.precio_alquiler, 
                    i.direccion, 
                    i.metros_cuadrados, 
                    i.ruta_foto AS ImagenUrl,
                    NULL AS habitaciones, 
                    NULL AS baños, 
                    NULL AS salon, 
                    NULL AS armarios, 
                    NULL AS Terrazas, 
                    NULL AS garaje, 
                    NULL AS gas, -- No aplica para Local
                    NULL AS calefaccion,
                    l.zona AS Zona, -- Cambiado a Zona
                    NULL AS Parcela, -- No aplica para Local
                    pr.nombre AS NombrePropietario,
                    o.ubicacion AS NombreOficina,
                    l.agua As Agua, -- Aplica para Local
                    l.es_diafano AS EsDiafano, -- Aplica para Local
                    l.altillo_altura AS AltilloAltura, -- Aplica para Local
                    l.vado AS Vado, -- Aplica para Local
                    l.esta_acondicionado AS EstaAcondicionado, -- Aplica para Local
                    l.numero_puertas AS NumeroPuertas, -- Aplica para Local
                    l.luz AS Luz -- Aplica solo para Local
                FROM 
                    Locales l
                JOIN 
                    Inmueble i ON l.id_inmueble = i.id
                JOIN 
                    Propietario pr ON i.id_propietario = pr.id
                JOIN 
                    Oficina o ON i.id_oficina = o.id
                WHERE 
                    i.id_oficina = @idOficina";
                
            DA dbAccess = new DA();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idOficina", idOficina);
            SqlDataReader reader = dbAccess.GetConsult(cmd);

            while (reader.Read())
            {
                PropiedadCompleta propiedad = new PropiedadCompleta
                {
                    propietario = reader["NombrePropietario"].ToString(),
                    oficina = reader["NombreOficina"].ToString(),
                    idInmueble = Convert.ToInt32(reader["IdInmueble"]),
                    tipo = reader["Tipo"].ToString(),
                    precioVenta = Convert.ToDecimal(reader["precio_venta"]),
                    precioAlquiler = Convert.ToDecimal(reader["precio_alquiler"]),
                    direccion = reader["direccion"].ToString(),
                    metrosCuadrados = Convert.ToDecimal(reader["metros_cuadrados"]),
                    imagenUrl = reader["ImagenUrl"].ToString(),
                    habitaciones = reader["habitaciones"] != DBNull.Value ? Convert.ToInt32(reader["habitaciones"]) : (int?)null,
                    baños = reader["baños"] != DBNull.Value ? Convert.ToInt32(reader["baños"]) : (int?)null,
                    salon = reader["salon"] != DBNull.Value ? Convert.ToBoolean(reader["salon"]) : (bool?)null,
                    armarios = reader["armarios"] != DBNull.Value ? Convert.ToInt32(reader["armarios"]) : (int?)null,
                    terraza = reader["Terrazas"] != DBNull.Value ? Convert.ToDecimal(reader["Terrazas"]) : (decimal?)null,
                    garaje = reader["garaje"] != DBNull.Value ? Convert.ToBoolean(reader["garaje"]) : (bool?)null,
                    gas = reader["gas"] != DBNull.Value ? Convert.ToBoolean(reader["gas"]) : (bool?)null,
                    calefaccion = reader["calefaccion"] != DBNull.Value ? Convert.ToBoolean(reader["calefaccion"]) : (bool?)null,
                    zona = reader["Zona"].ToString(),
                    parcela = reader["Parcela"].ToString(),
                    esDiafano = reader["EsDiafano"] != DBNull.Value ? Convert.ToBoolean(reader["EsDiafano"]) : (bool?)null,
                    altilloAltura = reader["AltilloAltura"] != DBNull.Value ? Convert.ToDecimal(reader["AltilloAltura"]) : (decimal?)null,
                    vado = reader["Vado"] != DBNull.Value ? Convert.ToBoolean(reader["Vado"]) : (bool?)null,
                    agua = reader["Agua"] != DBNull.Value ? Convert.ToBoolean(reader["Agua"]) : (bool?)null,
                    luz = reader["Luz"] != DBNull.Value ? Convert.ToBoolean(reader["Luz"]) : (bool?)null,
                    estaAcondicionado = reader["EstaAcondicionado"] != DBNull.Value ? Convert.ToBoolean(reader["EstaAcondicionado"]) : (bool?)null,
                    numeroPuertas = reader["NumeroPuertas"] != DBNull.Value ? Convert.ToInt32(reader["NumeroPuertas"]) : (int?)null
                };
                propiedades.Add(propiedad);
            }
            return propiedades;
        }
        public DataTable? GetVisitas(int idInmueble)
        {
            DataTable dt = new DataTable();
            try
            {

                string consulta = "SELECT v. id, v.id_inmueble, c.nombre AS nombre, c.telefono AS telefono, v.comment, v.fecha, v.hora FROM Visitas v INNER JOIN Cliente c ON v.id_cliente = c.id WHERE id_inmueble=@id_inmueble";
                DA db = new DA();
                db.connection.Open();
                SqlCommand command = new SqlCommand(consulta, db.connection);
                command.Parameters.AddWithValue("@id_inmueble", idInmueble);
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
