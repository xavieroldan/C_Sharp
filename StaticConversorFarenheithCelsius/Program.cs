using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConversorFarenheithCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100 grados Fahrenheit son {0} grados celsius", TempConversor.FahrenheitToCelsius(100));
            Console.WriteLine("30 grados C son {0} grados Fahrenheit",TempConversor.CelsiusToFahrenheit(30));
            Console.ReadKey();
        }
    }
}
