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
    public partial class PropertyCard : UserControl
    {
        public PropertyCard()
        {
            InitializeComponent();
        }
        public string Tipo
        {
            get => titulo.Text;
            set => titulo.Text = value;
        }

        public string PrecioVenta
        {
            get => precio_venta.Text;
            set => precio_venta.Text = "RD$" + value;
        }

        public string PrecioAlquiler
        {
            get => precio_alquiler.Text;
            set => precio_alquiler.Text = "RD$" + value;
        }

        public string Referencia
        {
            get => codigo.Text;
            set => codigo.Text = "Ref. " + value;
        }

        public Image ImagenPropiedad
        {
            get => imagen_inmueble.Image;
            set => imagen_inmueble.Image = value;
        }
    }
}
