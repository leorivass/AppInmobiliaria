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
    public partial class AñadirOficina : Form
    {
        public AñadirOficina()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telefonoOficina_TextChanged(object sender, EventArgs e)
        {
            string telefonoFormateado = telefonoOficina.Text.Replace("-", "");

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

            telefonoOficina.Text = telefonoFormateado;
            telefonoOficina.SelectionStart = telefonoOficina.Text.Length;
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Oficina oficina = new Oficina();

                oficina.ubicacion = ubicacionOficina.Text;
                oficina.telefono = telefonoOficina.Text;

                if (String.IsNullOrEmpty(ubicacionOficina.Text) || String.IsNullOrEmpty(telefonoOficina.Text))
                {
                    MessageBox.Show("Entrada no válida. Por favor, ingrese los campos faltantes.");
                    return;
                }

                if (oficina.DoesThisOfficeExist())
                {
                    MessageBox.Show("Esta oficina ya se encuentra registrada.");
                }
                else
                {
                    oficina.Add();
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
