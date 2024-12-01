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
            AñadirInmueble añadirinmueble = new AñadirInmueble();
            añadirinmueble.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            AñadirPropietario añadirpropietario = new AñadirPropietario();
            añadirpropietario.ShowDialog();
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            anadiroficina añadiroficina = new anadiroficina();
            añadiroficina.ShowDialog();
        }
    }
}
