using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Triangulo
    {

        double ba;
        double alt;

        public Triangulo(double ba, double alt)
        {
            this.ba = ba;
            this.alt = alt;
        }

        public double CalcArea()
        {
            return (ba * alt) / 2;
        }
    }
}
