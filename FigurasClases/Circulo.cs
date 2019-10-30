using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Circulo
    {
        private double _Radio;
        public Circulo (double radio)
        {
            Radio = radio;
        }

        public double Radio { get => _Radio; set => _Radio = value; }

        public double CalcArea ()
        {
            return Math.PI * (Math.Pow(this.Radio, 2));
        }

        public double GetRadio ()
        {
            return Radio;
        }
        
    }
}
