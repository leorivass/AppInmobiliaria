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
           CrearFicha crearficha = new CrearFicha("Santo Domingo");
            crearficha.ShowDialog();

        }
    }
}
