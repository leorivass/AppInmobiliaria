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


namespace Presentation
{
    public partial class AñadirInmueble : Form
    {
        private string office;
        private string imagePath = string.Empty;
        private string blobConnectionString = ConfigurationManager.ConnectionStrings["BLOBString"].ConnectionString;
        private string container = "estateimages";

        public AñadirInmueble()
        {
            InitializeComponent();
            CargarOficinas();
            CargarPropietarios();
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
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void continuarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener ID del propietario seleccionado
                int idPropietario = Convert.ToInt32(propietarioComboBox.SelectedValue);

                // Obtener ID de la oficina seleccionada
                int idOficina = Convert.ToInt32(oficinaComboBox.SelectedValue);

                // Agregar inmueble a la base de datos
                Inmueble inmueble = new Inmueble();

                inmueble.id_oficina = idOficina;
                inmueble.id_propietario = idPropietario;
                inmueble.precio_venta = float.Parse(precioVenta.Text);
                inmueble.precio_alquiler = float.Parse(precioAlquiler.Text);
                inmueble.direccion = direccion.Text;
                inmueble.metros_cuadrados = float.Parse(area.Text);
                inmueble.ruta_foto = subirImagenAzure();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
