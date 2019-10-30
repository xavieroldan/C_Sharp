using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligono
{
    internal class Triangulo: Poligono
    {
        private double _Lado1;
        private double _Lado2;
        private double _Lado3;

        public Triangulo(int numLados, double lado1, double lado2, double lado3) : base (numLados)
        {            
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public double Lado1 { get => _Lado1; set => _Lado1 = value; }
        public double Lado2 { get => _Lado2; set => _Lado2 = value; }
        public double Lado3 { get => _Lado3; set => _Lado3 = value; }

        public new string Hola()
        {
            return "Hola Mundo";
        }

    }
}
