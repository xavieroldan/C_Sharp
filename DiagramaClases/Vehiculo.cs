using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    abstract class Vehiculo
    {
        private string nombreVehiculo;
        private static int num = 0;

        public string NombreVehiculo { get => nombreVehiculo; set => nombreVehiculo = value; }
        protected static int Num { get => num; set => num = value; }

        public string GetNameVehicle() { return NombreVehiculo; }
        public abstract void Transportar();
        public static int NumVehiculos(){return Vehiculo.Num;}
    }
}
