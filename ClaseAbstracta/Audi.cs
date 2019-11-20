using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Audi : AsbtractaCoche
    {
        private int _Potencia;

        public Audi(int potencia)
        {
            Potencia = potencia;
        }
        public override int Potencia { get => _Potencia; set => _Potencia= value; }
        public override void Encender()
        {
            Console.WriteLine("Me enciendo!"); 
        }
    }
}
