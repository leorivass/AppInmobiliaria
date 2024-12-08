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
    public partial class AñadirCliente : Form
    {
        public AñadirCliente()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.nombre = nombreCliente.Text;
                cliente.telefono = telefonoCliente.Text;
                cliente.correo = correoCliente.Text;
                cliente.cedula = cedulaCliente.Text;

                if (String.IsNullOrEmpty(nombreCliente.Text) || String.IsNullOrEmpty(telefonoCliente.Text) || String.IsNullOrEmpty(correoCliente.Text) || String.IsNullOrEmpty(cedulaCliente.Text))
                {
                    MessageBox.Show("Entrada no válida. Por favor, ingrese los campos faltantes.");
                    return;
                }

                if (cliente.DoesThisClientExist())
                {
                    MessageBox.Show("Esta cédula ya se encuentra registrada.");
                }
                else
                {
                    cliente.Add();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
