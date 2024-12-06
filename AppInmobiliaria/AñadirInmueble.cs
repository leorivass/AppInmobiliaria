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
        }
        private void CargarPropietarios()
        {
            Propietario propietario = new Propietario();
            propietarioComboBox.DataSource = propietario.GetAllOwners();
            propietarioComboBox.DisplayMember = "descripcion";
            propietarioComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
