using BusinessLogic;
using System.Configuration;
using Azure.Storage.Blobs;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Presentation
{
    public partial class AñadirInmueble : Form
    {
        private string office;
        private string imagePath = string.Empty;
        private string blobConnectionString = ConfigurationManager.ConnectionStrings["BLOBString"].ConnectionString;
        private string container = "estateimages";
        private adminPage mainpage;

        public AñadirInmueble(adminPage mainpage)
        {
            InitializeComponent();
            CargarOficinas();
            CargarPropietarios();
            casaPanel.Visible = true;
            this.mainpage = mainpage;
        }
        private string subirImagenAzure()
        {
            try
            {
                // Crear un cliente de blob para el contenedor
                BlobServiceClient blobServiceClient = new BlobServiceClient(blobConnectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(container);

                // Asegurarse de que el contenedor exista
                containerClient.CreateIfNotExists();

                // Obtener el nombre del archivo
                string nombreArchivo = Path.GetFileName(imagePath);

                // Crear un cliente para el blob
                BlobClient blobClient = containerClient.GetBlobClient(nombreArchivo);

                // Subir el archivo
                using (FileStream stream = File.OpenRead(imagePath))
                {
                    blobClient.Upload(stream, true);
                }

                // Devolver la URL pública del blob
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void subirImagenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de imagen|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                imagenInmueble.Image = Image.FromFile(imagePath);
                imagenInmueble.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        private void CargarOficinas()
        {
            Oficina oficina = new Oficina();
            oficinaComboBox.DataSource = oficina.GetAllOffices();
            oficinaComboBox.DisplayMember = "descripcion";
            oficinaComboBox.ValueMember = "id";
            oficinaComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void CargarPropietarios()
        {
            Propietario propietario = new Propietario();
            propietarioComboBox.DataSource = propietario.GetAllOwners();
            propietarioComboBox.DisplayMember = "descripcion";
            propietarioComboBox.ValueMember = "id";
            propietarioComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void tipoInmuebleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoInmuebleComboBox.SelectedItem)
            {
                case "Casa":
                    casaPanel.Visible = true;
                    villaPanel.Visible = false;
                    pisoPanel.Visible = false;
                    localPanel.Visible = false;
                    break;

                case "Villa":
                    casaPanel.Visible = false;
                    villaPanel.Visible = true;
                    pisoPanel.Visible = false;
                    localPanel.Visible = false;
                    break;

                case "Piso":
                    casaPanel.Visible = false;
                    villaPanel.Visible = false;
                    pisoPanel.Visible = true;
                    localPanel.Visible = false;
                    break;

                case "Local":
                    casaPanel.Visible = false;
                    villaPanel.Visible = false;
                    pisoPanel.Visible = false;
                    localPanel.Visible = true;
                    break;
            }
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void continuarButton_Click(object sender, EventArgs e)
        {
            int idVivienda = 0;
            int codigo = 0;

            try
            {
                int idPropietario = Convert.ToInt32(propietarioComboBox.SelectedValue);

                int idOficina = Convert.ToInt32(oficinaComboBox.SelectedValue);

                Inmueble inmueble = new Inmueble();

                inmueble.id_oficina = idOficina;
                inmueble.id_propietario = idPropietario;
                inmueble.precio_venta = float.Parse(precioVenta.Text);
                inmueble.precio_alquiler = float.Parse(precioAlquiler.Text);
                inmueble.direccion = direccion.Text;
                inmueble.metros_cuadrados = float.Parse(area.Text);
                inmueble.ruta_foto = subirImagenAzure();

                int idInmueble = inmueble.Add();

                Vivienda vivienda = new Vivienda();

                switch (tipoInmuebleComboBox.SelectedItem)
                {
                    case "Casa":
                        vivienda.habitaciones = int.Parse(cantidadHabitaciones3.Text);
                        vivienda.baños = int.Parse(cantidadBaños3.Text);
                        vivienda.salon = salonCheckBox3.Checked;
                        vivienda.armarios = int.Parse(cantidadArmarios3.Text);
                        vivienda.m2_terraza = float.Parse(areaTerraza3.Text);
                        vivienda.garaje = garajeCheckBox3.Checked;
                        vivienda.gas = gasCheckBox3.Checked;
                        vivienda.calefaccion = calefaccionCheckBox3.Checked;
                        vivienda.id_inmueble = idInmueble;

                        idVivienda = vivienda.Add();

                        Casa casa = new Casa();

                        casa.zona = zonaCasa.Text;
                        casa.id_vivienda = idVivienda;

                        codigo = casa.Add();

                        break;

                    case "Villa":
                        vivienda.habitaciones = int.Parse(cantidadHabitaciones1.Text);
                        vivienda.baños = int.Parse(cantidadBaños1.Text);
                        vivienda.salon = salonCheckBox1.Checked;
                        vivienda.armarios = int.Parse(cantidadArmarios1.Text);
                        vivienda.m2_terraza = float.Parse(areaTerraza1.Text);
                        vivienda.garaje = garajeCheckBox1.Checked;
                        vivienda.gas = gasCheckBox1.Checked;
                        vivienda.calefaccion = calefaccionCheckBox1.Checked;
                        vivienda.id_inmueble = idInmueble;

                        idVivienda = vivienda.Add();

                        Villa villa = new Villa();

                        villa.urbanizacion = urbanizacionVilla.Text;
                        villa.parcela = parcelaVilla.Text;
                        villa.id_vivienda = idVivienda;

                        codigo = villa.Add();

                        break;

                    case "Piso":
                        vivienda.habitaciones = int.Parse(cantidadHabitaciones2.Text);
                        vivienda.baños = int.Parse(cantidadBaños2.Text);
                        vivienda.salon = salonCheckBox2.Checked;
                        vivienda.armarios = int.Parse(cantidadArmarios2.Text);
                        vivienda.m2_terraza = float.Parse(areaTerraza2.Text);
                        vivienda.garaje = garajeCheckBox2.Checked;
                        vivienda.gas = gasCheckBox2.Checked;
                        vivienda.calefaccion = calefaccionCheckBox2.Checked;
                        vivienda.id_inmueble = idInmueble;

                        idVivienda = vivienda.Add();

                        Piso piso = new Piso();

                        piso.zona = zonaPiso.Text;

                        if (tipoPisoComboBox.SelectedItem == "Nuevo")
                        {
                            piso.nuevo = true;
                            piso.ocasion = false;
                        }
                        else
                        {
                            piso.nuevo = false;
                            piso.ocasion = true;
                        }

                        piso.id_vivienda = idVivienda;

                        codigo = piso.Add();
                  
                        break;

                    case "Local":
                        Local local = new Local();

                        local.zona = zonaLocal.Text;
                        local.esDiafano = diafanoCheckBox.Checked;
                        local.altilloAltura = float.Parse(alturaAltillo.Text);
                        local.vado = vadoCheckBox.Checked;
                        local.agua = aguaCheckBox.Checked;
                        local.luz = luzCheckBox.Checked;
                        local.estaAcondicionado = acondicionadoCheckBox.Checked;
                        local.numeroPuertas = int.Parse(numeroPuertas.Text);
                        local.id_inmueble = idInmueble;

                        codigo = local.Add();

                        break;
                }

                string tipo = tipoInmuebleComboBox.SelectedItem.ToString();
                string precio_venta = inmueble.precio_venta.ToString();
                string precio_alquiler = inmueble.precio_alquiler.ToString();
                string referencia = codigo.ToString();
                string imagenPropiedad = inmueble.ruta_foto;

                mainpage.AddPropertyCard(tipo, precio_venta, precio_alquiler, referencia, imagenPropiedad);

                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
