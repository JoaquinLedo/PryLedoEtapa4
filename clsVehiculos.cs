using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class clsVehiculo
{
    public string tipoVehiculo;

    public void CrearAuto()
    {
        tipoVehiculo = "Auto";
    }

    public void CrearAvion()
    {
        tipoVehiculo = "Avión";
    }

    public void CrearBarco()
    {
        tipoVehiculo = "Barco";
    }
}