using BusinessLogic;
using MaterialSkin.Controls;
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
    public partial class FichaLocal : Form
    {
        public FichaLocal()
        {
            InitializeComponent();
        }

        public void EnviarDatosLocal(PropiedadCompleta propiedad)
        {
            label1.Text = propiedad.tipo;
            materialTextBox21.Text = propiedad.oficina;
            materialTextBox22.Text = propiedad.propietario;
            materialTextBox23.Text = propiedad.precioVenta.ToString();
            materialTextBox24.Text = propiedad.precioAlquiler.ToString();
            materialTextBox25.Text = propiedad.direccion;
            materialTextBox26.Text = propiedad.metrosCuadrados.ToString();
            materialTextBox27.Text = propiedad.altilloAltura.ToString();
            materialTextBox28.Text = propiedad.numeroPuertas.ToString();
            materialTextBox29.Text = propiedad.zona.ToString();
            materialCheckbox1.Checked = (bool)propiedad.esDiafano;
            materialCheckbox2.Checked = (bool)propiedad.vado;
            materialCheckbox3.Checked = (bool)propiedad.agua;
            materialCheckbox4.Checked = (bool)propiedad.luz;
            materialCheckbox5.Checked = (bool)propiedad.estaAcondicionado;
            dataGridView1.DataSource = propiedad.GetVisitas(propiedad.idInmueble);

            return;
        }
    }
}
