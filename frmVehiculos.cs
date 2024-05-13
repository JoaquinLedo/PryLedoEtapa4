using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLedoEtapa4
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmVehiculos_KeyDown);
            this.Focus();

            objAuto = new clsVehiculos();
            objAvion = new clsVehiculos();
            objBarco = new clsVehiculos();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }
        List<clsVehiculos> listaVehiculos = new List<clsVehiculos>();
        clsVehiculos objAuto;
        clsVehiculos objAvion;
        clsVehiculos objBarco;
        
        private void BtnVehiculos_Click(object sender, EventArgs e)
        {
            listaVehiculos.Add(objAuto);
            listaVehiculos.Add(objAvion);
            listaVehiculos.Add(objBarco);

            lstMostrarVehiculos.Items.Clear();

            foreach (clsVehiculos vehiculo in listaVehiculos)
            {
                lstMostrarVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculos();
            objAvion = new clsVehiculos();
            objBarco = new clsVehiculos();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }

        private void frmVehiculos_KeyDown(object sender, KeyEventArgs e)
        {
            // Determinar qué tecla se presionó y llamar a la función CrearVehiculo con el tipo correspondiente
            switch (e.KeyCode)
            {
                case Keys.A:
                    CrearVehiculo("auto");
                    break;
                case Keys.S:
                    CrearVehiculo("avion");
                    break;
                case Keys.D:
                    CrearVehiculo("barco");
                    break;
            }
        }
        private void CrearVehiculo(string tipoVehiculo)
        {
            // Lógica para determinar la posición en la pantalla (aquí se muestra un ejemplo simple)
            Random rnd = new Random();
            int x = rnd.Next(this.Width - 100); // Ancho del formulario
            int y = rnd.Next(this.Height - 100); // Alto del formulario 

            // Crear un nuevo PictureBox para mostrar el vehículo
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(100, 100); // Tamaño de la imagen
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Crear un nuevo Label para mostrar el tipo de vehículo
            Label label = new Label();
            label.Text = tipoVehiculo;
            label.AutoSize = true;
            label.Location = new Point(x, y + 100); // Colocar el Label debajo del PictureBox

            // Crear un nuevo vehículo
            switch (tipoVehiculo)
            {
                case "auto":
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("auto");
                    break;
                case "barco":
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("barco");
                    break;
                case "avion":
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("avion");
                    break;
                default:
                    return; // No se reconoce el tipo de vehículo, salir sin crear nada
            }

            // Agregar el PictureBox y el Label al formulario
            this.Controls.Add(pictureBox);
            this.Controls.Add(label);

        }
    }
}
