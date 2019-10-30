using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe", "Pérez", "3232323232Z");

            Cliente cliente1 = new Cliente("Jose", "Rodriguez", "5555555555Z", 35, "LocalSoft", "Barcelona");

            Persona cliente2 = new Cliente("Pipo", "López", "Méndez",55,"Lolo","Murcia");

            Console.WriteLine(cliente2.GetType());

            Console.ReadKey();
        }
    }
}
