using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    sealed class Velero : Acuatico
    {
        private static int num = 0;
        public Velero(string vhName, string acuName)
        {
            this.NombreVehiculo = vhName;
            this.NombreAcuatico = acuName;
            Vehiculo.Num++;
            Acuatico.num++;
            num++;

        }
        public override void Navegar() {Console.WriteLine("Estoy navegando a vela");}
        public void IzarVelas() {Console.WriteLine("Velas izadas");}
        public new static int NumVehiculos(){return Velero.num;}
    }
}
