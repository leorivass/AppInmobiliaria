using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation
{
    public partial class AñadirPropietario : Form
    {
        public AñadirPropietario()
        {
            InitializeComponent();
        }

        private void cedulaPropietario_TextChanged(object sender, EventArgs e)
        {
            string cedulaFormateada = cedulaPropietario.Text.Replace("-", "");

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

            cedulaPropietario.Text = cedulaFormateada;
            cedulaPropietario.SelectionStart = cedulaPropietario.Text.Length;
        }

        private void telefonoPropietario_TextChanged(object sender, EventArgs e)
        {
            string telefonoFormateado = telefonoPropietario.Text.Replace("-", "");

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

            telefonoPropietario.Text = telefonoFormateado;
            telefonoPropietario.SelectionStart = telefonoPropietario.Text.Length;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario propietario = new Propietario();

                propietario.nombre = nombrePropietario.Text;
                propietario.telefono = telefonoPropietario.Text;
                propietario.correo = correoPropietario.Text;
                propietario.cedula = cedulaPropietario.Text;

                if (String.IsNullOrEmpty(nombrePropietario.Text) || String.IsNullOrEmpty(telefonoPropietario.Text) || String.IsNullOrEmpty(correoPropietario.Text) || String.IsNullOrEmpty(cedulaPropietario.Text))
                {
                    MessageBox.Show("Entrada no válida. Por favor, ingrese los campos faltantes.");
                    return;
                }

                if (propietario.DoesThisOwnerExist())
                {
                    MessageBox.Show("Esta cédula ya se encuentra registrada.");
                }
                else
                {
                    propietario.Add();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
