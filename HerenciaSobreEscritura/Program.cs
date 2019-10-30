using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSobreEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia del padre
            Padre clasePadre = new Padre();
            Console.WriteLine(clasePadre.Hola());

            //Instancia de hija 1
            Hija1 claseHija1 = new Hija1("A");
            Console.WriteLine(claseHija1.Hola());

            //Casting de hija en padre 1 (override) Usa sus métodos escritos
            Hija1 claseA = new Hija1("A");
            Padre clase = claseA;
            Console.WriteLine(clase.Hola());

            //Casting de hija en padre 2 (new) Usa métodos del padre
            Hija2 claseHija2 = new Hija2("B");
            Console.WriteLine(claseHija2.Hola());

            Hija2 claseB2 = new Hija2("B");
            Padre clase2 = claseB2;
            Console.WriteLine(clase2.Hola());

            //End
            Console.ReadKey();
        }
    }

    public class Padre
    {
        protected string Nombre;

        public Padre()
        {
            Nombre = "Base";
        }
        //Regresa un string
        public virtual string Hola()
        {
            return "metodopadre-Soy " + Nombre;
        }
    }

    //Clase que sobreescribe el metodo quienSoy
    public class Hija1 : Padre
    {
        public Hija1(string nombre)
        {
            Nombre = nombre;
        }

        public override string Hola()
        {
            return "metodohija1-Me llamo " + Nombre;
        }
    }

    //Clase que oculta el metodo quienSoy
    public class Hija2 : Padre
    {
        public Hija2(string nombre)
        {
            Nombre = nombre;
        }

        public new string Hola()
        {
            return "metodohija2-Mi nombre es " + Nombre;
        }
    }
}
