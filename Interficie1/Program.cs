using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interficie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento doc1 = new Documento();
            doc1.Escribir();
            doc1.Leer();
            doc1.Imprimir();

            Rectangulo rec1 = new Rectangulo();
            rec1.Imprimir();
        }
    }
}
