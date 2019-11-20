using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interficie1
{
    class Documento : IntImprimir, IntArchivo
    {
        private string _Contenido;

        public Documento() 
        {
            Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        }

        public string Contenido { get => _Contenido; set => _Contenido = value; }

        public void Escribir()
        {
            Console.WriteLine("Escribiendo");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo");
        }

        public void Leer()
        {
            Console.WriteLine("Leyendo");
        }
    }
}
