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
        private void telefonoCliente_TextChanged(object sender, EventArgs e)
        {
            string telefonoFormateado = telefonoCliente.Text.Replace("-", "");

            telefonoFormateado = new string(telefonoFormateado.Where(char.IsDigit).ToArray());

            if (telefonoFormateado.Length >= 11)
            {
                telefonoFormateado = telefonoFormateado.Substring(0, 10);
            }

            if (telefonoFormateado.Length >= 4)
            {
                telefonoFormateado = telefonoFormateado.Insert(3, "-");
            }
            if (telefonoFormateado.Length >= 8)
            {
                telefonoFormateado = telefonoFormateado.Insert(7, "-");
            }

            telefonoCliente.Text = telefonoFormateado;
            telefonoCliente.SelectionStart = telefonoCliente.Text.Length;
        }

        private void cedulaCliente_TextChanged(object sender, EventArgs e)
        {
            string cedulaFormateada = cedulaCliente.Text.Replace("-", "");

            cedulaFormateada = new string(cedulaFormateada.Where(char.IsDigit).ToArray());

            if (cedulaFormateada.Length >= 12)
            {
                cedulaFormateada = cedulaFormateada.Substring(0, 11);
            }

            if (cedulaFormateada.Length >= 4)
            {
                cedulaFormateada = cedulaFormateada.Insert(3, "-");
            }

            if (cedulaFormateada.Length >= 12)
            {
                cedulaFormateada = cedulaFormateada.Insert(11, "-");
            }

            cedulaCliente.Text = cedulaFormateada;
            cedulaCliente.SelectionStart = cedulaCliente.Text.Length;
        }
    }
}
