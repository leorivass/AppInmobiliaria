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
    public partial class AñadirVisita : Form
    {
        public AñadirVisita()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            Cliente cliente = new Cliente();
            clienteComboBox.DataSource = cliente.GetAllClients();
            clienteComboBox.DisplayMember = "descripcion";
            clienteComboBox.ValueMember = "id";
            clienteComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(clienteComboBox.SelectedValue);

            Inmueble inmueble = new Inmueble();

            if (inmueble.DoesThisPropertyExist(int.Parse(idInmueble.Text)))
            {
                Visita visita = new Visita();

                visita.id_inmueble = int.Parse(idInmueble.Text);
                visita.id_cliente = idCliente;
                visita.comentario = comentarioVisita.Text;

                visita.Add();
            }
            else
            {
                MessageBox.Show("El ID de inmueble que trata de ingresar no está registrado.");
            }

            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
