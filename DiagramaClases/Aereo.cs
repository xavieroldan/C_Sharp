using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    abstract class Aereo : Vehiculo
    {
        private string _NombreAereo;
        protected static int num = 0;

        public string NombreAereo { get => _NombreAereo; set => _NombreAereo = value; }

        public override void Transportar() {Console.WriteLine("Estoy transportando");}

        abstract public void Volar();

        public new static int NumVehiculos() { return Aereo.num; }
    }
}
