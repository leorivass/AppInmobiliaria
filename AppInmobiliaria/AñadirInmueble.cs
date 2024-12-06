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
        }
        private void CargarOficinas()
        {
            Oficina oficina = new Oficina();
            oficinaComboBox.DataSource = oficina.GetAllOffices();
            oficinaComboBox.DisplayMember = "Descripcion";
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
