using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    sealed class Barco : Acuatico
    {
        private static int num = 0;
        public Barco(string vhName, string acuName)
        {
            this.NombreVehiculo = vhName;
            this.NombreAcuatico = acuName;
            Vehiculo.Num++;
            Acuatico.num++;
            num++;
        }
        
        public override void Navegar(){Console.WriteLine("Estoy navegando a motor");}
        public void PrenderMotor(){Console.WriteLine("Arranco motor");}
        public new static int NumVehiculos(){return Barco.num;}
    }
}
