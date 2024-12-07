﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Microsoft.Data.SqlClient;


namespace Presentation
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
            CargarOficinas();
        }
        private void CargarOficinas()
        {
            Oficina oficina = new Oficina();
            oficinaComboBox.DataSource = oficina.GetAllOffices();
            oficinaComboBox.DisplayMember = "descripcion";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            CargarOficinas();
        }


        private void añadirPropietarioButton_Click(object sender, EventArgs e)
        {
            AñadirPropietario añadirpropietario = new AñadirPropietario();
            añadirpropietario.ShowDialog();
        }

        private void añadirOficinaButton_Click(object sender, EventArgs e)
        {
            AñadirOficina añadiroficina = new AñadirOficina();
            añadiroficina.ShowDialog();
        }

        private void añadirInmuebleButton_Click(object sender, EventArgs e)
        {
            AñadirInmueble añadirinmueble = new AñadirInmueble();
            añadirinmueble.ShowDialog();
        }

        private void propietariosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.CargarPropietarios(propietariosGridView);
            Oficina oficina = new Oficina();
            oficina.CargarOficinas(oficinasGridView);
            propietariosGridView.ReadOnly = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.CargarPropietarios(propietariosGridView);
        }

        private void oficinasGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Oficina oficina = new Oficina();
            oficina.CargarOficinas(oficinasGridView);
        }

        private void eliminarPropietarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = new Propietario();
                DataGridViewRow selectedRow = propietariosGridView.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                propietario.DeletePropietario(id);
                MessageBox.Show("Propietario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el propietario: " + ex.Message);
            }
        }

        private void eliminarOficinaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Oficina oficina = new Oficina();
                DataGridViewRow selectedRow = oficinasGridView.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                oficina.DeleteOficina(id);
                MessageBox.Show("Oficina eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar oficina: " + ex.Message);
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)

        {
            Propietario propietario = new Propietario();
            if (propietariosGridView.SelectedRows.Count > 0)
            {
                try
                {
                    if (propietariosGridView.SelectedRows.Count > 0)
                    {
                        
                        DataGridViewRow selectedRow = propietariosGridView.SelectedRows[0];

                        
                        int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                        string nombre = selectedRow.Cells["nombre"].Value.ToString();
                        string telefono = selectedRow.Cells["telefono"].Value.ToString();
                        string correo = selectedRow.Cells["correo"].Value.ToString();
                        string cedula = selectedRow.Cells["cedula"].Value.ToString();

                        
                        Propietario.EditPropietario(id, nombre, telefono, correo, cedula);

                        
                        MessageBox.Show("Propietario actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una fila para editar.");
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al actualizar el propietario: " + ex.Message);
                }
            }
        }
    }
}



