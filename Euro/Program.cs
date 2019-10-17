using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Visual C# 2012 Express - FrameWork 4.5";

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");

            Console.InputEncoding = Encoding.Default;
            Console.OutputEncoding = Encoding.Default;

            // Variable.
            string Variable;
            string euro = "€€€€€€€€€";

            //Mostrar mensaje en pantalla.
            Console.WriteLine(@"Introduces signos como el Euro para mostrarlo en pantalla:
            Introduce el símbolo del Euros del teclado.");

            // Esperando entrada de datos, este ejemplo insertamos la letra €.
            Variable = Console.ReadLine();

            // Visualiza los datos introducidos en pantalla.
            Console.WriteLine("Se ha introducido la letra €: {0}", Variable);
            Console.WriteLine(euro);

            // Espera tocar una tecla para salir.
            Console.ReadLine();

        }
    }
}
