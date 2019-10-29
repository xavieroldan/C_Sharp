using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Triangulo
    {

        private double _Ba;
        private double _Alt;

        public Triangulo(double ba, double alt)
        {
            Ba = ba;
            Alt = alt;
        }

        public double Ba { get => _Ba; set => _Ba = value; }
        public double Alt { get => _Alt; set => _Alt = value; }

        public double CalcArea()
        {
            return (Ba * Alt) / 2;
        }
    }
}
