using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    sealed class Avion : Aereo
    {
        private static int num =0;
        public Avion(string aerName, string vhName)
        {
            this.NombreAereo = aerName;
            this.NombreVehiculo = vhName;            
            Vehiculo.Num++;
            Aereo.num++;
            num++;
        }
        public override void Volar() { Console.WriteLine("Estoy volando en linea recta");}
        public void BajarTrenAterrizaje() { Console.WriteLine("Bajando tren de aterrizaje"); }
        public new static int NumVehiculos() { return Avion.num; }
    }
}
