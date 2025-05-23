﻿using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetAllOffices()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "select id, concat(ubicacion, ', ', telefono) as descripcion from Oficina";

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
        public void CargarOficinas(DataGridView oficinasGridView)
        {
            DataTable dat = new DataTable();
            try
            {

                string consulta = "select * from Oficina";
                DA db = new DA();
                db.connection.Open();
                SqlCommand command = new SqlCommand(consulta, db.connection);
                SqlDataReader reader = command.ExecuteReader();
                dat.Load(reader);
                oficinasGridView.AutoGenerateColumns = true;
                oficinasGridView.DataSource = dat;
                oficinasGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void DeleteOficina(int id)
        {
            try
            {
                string query = "DELETE FROM Oficina WHERE id = @id";


                DA db = new DA();

                SqlCommand cmd = new SqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@id", id);
                db.ExecuteQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la oficina: " + ex.Message, ex);
            }
        }
        public static void EditOficina(int id, string ubicacion, string telefono)
        {     
             try
                {
                    string query = "UPDATE Oficina SET ubicacion = @ubicacion, telefono = @telefono WHERE id = @id";
                    DA db = new DA();

                    SqlCommand cmd = new SqlCommand(query, db.connection);
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@id", id);
                    db.ExecuteQuery(cmd);

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar oficina: " + ex.Message, ex);
                }
        }
    }
}
