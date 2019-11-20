using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public abstract class Remolque
    {
        private int peso = 500;

        protected int Peso { get => peso; set => peso = value; }

        public abstract void Enganchar();
        public abstract void Arrancar();
        public abstract void Soltar();
    }
}
