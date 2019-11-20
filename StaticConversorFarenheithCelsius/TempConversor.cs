using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConversorFarenheithCelsius
{
    static class TempConversor
    {
        public static double FahrenheitToCelsius(int f)
        {
            return (f - 32) * 0.556;
        }
        public static double CelsiusToFahrenheit(int c)
        {
            return (c * 1.8) +32;
        }
    }
}
