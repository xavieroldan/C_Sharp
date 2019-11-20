using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    abstract class Acuatico : Vehiculo
    {
        private string _NombreAcuatico;
        protected static int num = 0;

        public string NombreAcuatico { get => _NombreAcuatico; set => _NombreAcuatico = value; }

        public override void Transportar(){Console.WriteLine("Estoy transportando por el agua");}

        abstract public void Navegar();

        public new static int NumVehiculos(){return Acuatico.num;}
    }
}
