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

            Persona personaCasteada = cliente1;

            Console.WriteLine("Soy un "+ personaCasteada.GetType().Name);
            personaCasteada.Hablar();// Uso el new como persona casteada (padre)

            Console.WriteLine("Soy un " + cliente1.GetType().Name);
            cliente1.Hablar();// Uso el método como cliente (hija)

            Console.ReadKey();
        }
    }
}
