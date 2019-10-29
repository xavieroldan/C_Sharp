using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook pepe = new Facebook("pepe");
            pepe.Password = "1111";
            pepe.Age = 55;

            Console.WriteLine(pepe.Name);
            Console.WriteLine(pepe.Age);
            Console.WriteLine(pepe.Password);

            Console.ReadKey();
        }
    }
}
