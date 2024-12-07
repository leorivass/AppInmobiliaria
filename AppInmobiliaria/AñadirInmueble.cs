using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class AñadirInmueble : Form
    {
        public AñadirInmueble()
        {
            InitializeComponent();
            CargarOficinas();
            CargarPropietarios();
        }
        private void CargarOficinas()
        {
            Oficina oficina = new Oficina();
            oficinaComboBox.DataSource = oficina.GetAllOffices();
            oficinaComboBox.DisplayMember = "descripcion";
            oficinaComboBox.ValueMember = "id";
            oficinaComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void CargarPropietarios()
        {
            Propietario propietario = new Propietario();
            propietarioComboBox.DataSource = propietario.GetAllOwners();
            propietarioComboBox.DisplayMember = "descripcion";
            propietarioComboBox.ValueMember = "id";
            propietarioComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void continuarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener ID del propietario seleccionado
                int idPropietario = Convert.ToInt32(propietarioComboBox.SelectedValue);

                // Obtener ID de la oficina seleccionada
                int idOficina = Convert.ToInt32(oficinaComboBox.SelectedValue);

                // Agregar inmueble a la base de datos
                Inmueble inmueble = new Inmueble();

                inmueble.id_oficina = idOficina;
                inmueble.id_propietario = idPropietario;
                inmueble.precio_venta = float.Parse(precioVenta.Text);
                inmueble.precio_alquiler = float.Parse(precioAlquiler.Text);
                inmueble.direccion = direccion.Text;
                inmueble.metros_cuadrados = float.Parse(area.Text);
            }
            catch (Exception ex) 
            {
                throw;
            }
        }
    }
}
