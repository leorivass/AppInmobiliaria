using Presentation;

namespace AppInmobiliaria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void crearFicha_Click(object sender, EventArgs e)
        {
            A�adirInmueble a�adirinmueble = new A�adirInmueble();
            a�adirinmueble.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            A�adirPropietario a�adirpropietario = new A�adirPropietario();
            a�adirpropietario.ShowDialog();
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            anadiroficina a�adiroficina = new anadiroficina();
            a�adiroficina.ShowDialog();
        }
    }
}
