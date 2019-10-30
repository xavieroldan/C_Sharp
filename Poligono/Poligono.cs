using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligono
{
    class Poligono
    {
        private int _NumLados;

        public Poligono(int numLados)
        {
            NumLados = numLados;
        }

        public int NumLados { get => _NumLados; set => _NumLados = value; }
    }
}
