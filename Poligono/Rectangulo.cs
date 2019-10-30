using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligono
{
    internal class Rectangulo : Poligono
    {
        private double _Lado1;
        private double _Lado2;

        public Rectangulo(int numLados, double lado1, double lado2) : base(numLados)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public double Lado1 { get => _Lado1; set => _Lado1 = value; }
        public double Lado2 { get => _Lado2; set => _Lado2 = value; }

    }
}
