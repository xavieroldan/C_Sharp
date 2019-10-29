using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            double salary = 0.0d;
            int age = 0, days =0;

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            Console.InputEncoding = Encoding.Default;
            Console.OutputEncoding = Encoding.Default;


            Console.WriteLine("Calculador de sueldo:");

            Console.WriteLine("Dame el nombre:");
            name =Console.ReadLine();
            Console.WriteLine("Dame el sueldo:");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la edad:");
            age = Convert.ToInt32(Console.ReadLine());

            ClsEmpleado juan = new ClsEmpleado(name, salary, age);

            Console.WriteLine("Dame los días trabajados:");
            days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} cobrará por {1} días trabajados {2:F2} €"
                , juan.Nombre
                , days
                , juan.CalcularSueldo(days));

            ClsEmpleado pepe = new ClsEmpleado("Pepe", 40);

            //Usando el set
            pepe.Nombre = "Paco";

            //Usando el set
            Console.WriteLine(pepe.Nombre);

            pepe.


            //End
            Console.ReadKey();
        }
    }
}
