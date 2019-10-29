using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Rectangulo
    {
        double ba;
        double alt;

        public Rectangulo(double ba, double alt)
        {
            this.ba = ba;
            this.alt = alt;
        }

        public double CalcArea()
        {
            return ba * alt;
        }
    }
}
