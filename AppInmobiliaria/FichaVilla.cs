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
    public partial class FichaVilla : Form
    {
        public FichaVilla()
        {
            InitializeComponent();
        }
        public void EnviarDatosVilla(PropiedadCompleta propiedad)
        {
            label1.Text = propiedad.tipo;
            materialTextBox21.Text = propiedad.oficina;
            materialTextBox22.Text = propiedad.propietario;
            materialTextBox23.Text = propiedad.precioVenta.ToString();
            materialTextBox24.Text = propiedad.precioAlquiler.ToString();
            materialTextBox25.Text = propiedad.direccion;
            materialTextBox26.Text = propiedad.metrosCuadrados.ToString();
            materialTextBox27.Text = propiedad.habitaciones.ToString();
            materialTextBox28.Text = propiedad.baños.ToString();
            materialTextBox210.Text = propiedad.armarios.ToString();
            materialTextBox211.Text = propiedad.terraza.ToString();
            materialCheckbox1.Checked = (bool)propiedad.salon;
            materialCheckbox2.Checked = (bool)propiedad.garaje;
            materialCheckbox3.Checked = (bool)propiedad.gas;
            materialCheckbox4.Checked = (bool)propiedad.calefaccion;
            materialTextBox212.Text = propiedad.parcela;
            materialTextBox29.Text = propiedad.zona;

            return;
        }
    }
}
