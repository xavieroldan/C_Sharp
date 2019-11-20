using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSealed
{
    class Rectangulo
    {
        private int _Lado1;
        private int _Lado2;

        public Rectangulo(int lado1, int lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public int Lado1 { get => _Lado1; set => _Lado1 = value; }
        public int Lado2 { get => _Lado2; set => _Lado2 = value; }
    }
}
