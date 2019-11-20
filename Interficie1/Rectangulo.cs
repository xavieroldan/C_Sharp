using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interficie1
{
    class Rectangulo : IntImprimir
    {
        private int _Ancho;
        private int _Alto;

        public Rectangulo()
        {
            Ancho = 10;
            Alto = 10;
        }

        public int Ancho { get => _Ancho; set => _Ancho = value; }
        public int Alto { get => _Alto; set => _Alto = value; }

        public void Imprimir()
        {
            Console.WriteLine("Estoy imprimiendo");
        }
    }
}
