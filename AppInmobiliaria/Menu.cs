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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
    }
}
