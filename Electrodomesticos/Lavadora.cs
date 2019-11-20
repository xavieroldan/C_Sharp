using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Lavadora : Electrodomestico
    {
        double _Carga;

        public Lavadora(double carga, double price, Color color, EnergyClass energyClass, double weight) 
            : base (price, color, energyClass, weight)
        {
            Carga = carga;
        }

        private double Carga { get => _Carga; set => _Carga = value; }
        public double GetCarga() { return Carga; }

        public override void PrecioFinal()
        {
            base.PrecioFinal();
            if(Carga>30) { base.Price += 50; }
        }
    }
}
