using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche MiCoche = new Coche(500);
            MiCoche.Enganchar();
            MiCoche.Arrancar();
            MiCoche.Soltar();
            Console.WriteLine("Peso:"+MiCoche.GetPeso());
            Console.ReadKey();
        }
    }
}
