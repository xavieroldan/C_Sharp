using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public abstract class AsbtractaCoche
    {
        public abstract int Potencia { get; set; } //properties
        public abstract void Encender(); //Abstract 
        public int Ruedas() { return 4; } // None abstract
    }
}
