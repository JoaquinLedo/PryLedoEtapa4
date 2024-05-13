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
       
        private List<clsVehiculo> listaVehiculos = new List<clsVehiculo>(); // Lista para almacenar los vehículos creados

        public frmVehiculos()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permitir que el formulario capture eventos de teclado antes de que se envíen a los controles secundarios

            // Manejar el evento KeyDown para detectar las teclas presionadas
            this.KeyDown += new KeyEventHandler(frmVehiculos_KeyDown);

            this.Focus(); // Enfocar el formulario al iniciarse
        }
        private void frmVehiculos_Load(object sender, EventArgs e) 
        {
        
        }
        private void BtnVehiculos_Click(object sender, EventArgs e)
        {
            lstMostrarVehiculos.Items.Clear();

            // Mostrar los tipos de vehículos en el ListBox
            foreach (clsVehiculo vehiculo in listaVehiculos)
            {
                lstMostrarVehiculos.Items.Add(vehiculo.tipoVehiculo);
            }
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
            // Crear un nuevo vehículo
            clsVehiculo vehiculo = new clsVehiculo();
            switch (tipoVehiculo)
            {
                case "auto":
                    vehiculo.CrearAuto();
                    break;
                case "avion":
                    vehiculo.CrearAvion();
                    break;
                case "barco":
                    vehiculo.CrearBarco();
                    break;
                default:
                    return; // No se reconoce el tipo de vehículo, salir sin crear nada
            }

            // Agregar el vehículo a la lista
            listaVehiculos.Add(vehiculo);
        }
    }

}