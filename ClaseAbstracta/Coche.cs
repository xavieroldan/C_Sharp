using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Coche : Remolque
    {
        public Coche(int peso)
        {
            this.Peso = peso;
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arranco");
        }

        public override void Enganchar()
        {
            Console.WriteLine("Engancho");
        }

        public override void Soltar()
        {
            Console.WriteLine("Suelto");
        }

        public int GetPeso () { return Peso; }
    }
}
