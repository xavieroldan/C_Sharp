using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    sealed class Helicoptero : Aereo
    {
        private static int num = 0;
        public Helicoptero(string aerName, string vhName)
        {
            this.NombreAereo = aerName;
            this.NombreVehiculo = vhName;
            Vehiculo.Num++;
            Aereo.num++;
            num++;
        }
        public override void Volar() { Console.WriteLine("Vuelo en todas direcciones"); }
        public void EncenderHelices() { Console.WriteLine("Enciendo hélices"); }
        public new static int NumVehiculos() {return Helicoptero.num;}
    }
}
