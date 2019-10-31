using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Persona
    {
        private string _Nombre;
        private string _Apellido;
        private string _Dni;

        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Dni { get => _Dni; set => _Dni = value; }

        
        public  void Hablar()
        {
            Console.WriteLine("Soy persona y Bla,bla,bla...");
        }
    }
}
