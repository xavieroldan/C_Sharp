using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Television : Electrodomestico
    {
        private double _Resolution = 20;
        private bool _Tdt = false;
        static int numInstances = 0;

        public Television(double resolution, bool tdt, double price, Color color, EnergyClass energyClass, double weight)
            : base(price, color, energyClass, weight)
        {
            Resolution = resolution;
            Tdt = tdt;
            numInstances++;
        }

        private double Resolution { get => _Resolution; set => _Resolution = value; }
        private bool Tdt { get => _Tdt; set => _Tdt = value; }

        public double GetResolution() { return Resolution; }
        public bool GetTdt () { return Tdt; }

        public override void PrecioFinal()
        {
            {
                base.PrecioFinal();
                if(Resolution>40) { base.Price *= 1.3; };
                if (Tdt) { base.Price += 50; }
            }
        }

        public int GetNumInstances()  {return numInstances; }
    }
}
