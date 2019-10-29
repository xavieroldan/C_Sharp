using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Circulo
    {
        double radio;
        public Circulo (double radio)
        {
            this.radio = radio;
        }

        public double CalcArea ()
        {
            return Math.PI * (Math.Pow(this.radio, 2));
        }
        
    }
}
