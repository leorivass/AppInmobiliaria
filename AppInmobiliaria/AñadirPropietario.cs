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
    public partial class AñadirPropietario : Form
    {
        public AñadirPropietario()
        {
            InitializeComponent();
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
