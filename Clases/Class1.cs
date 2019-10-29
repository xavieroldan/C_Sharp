using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class clsCirculo
    {
        public double radio;
        
        //constructor público y no devuelve nada
        public clsCirculo(int r) { this.radio = r; }

        public double calcularArea ()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public double calcularPerimetro()
        {
            return 2 * (Math.PI) * radio;
        }
    }
}
