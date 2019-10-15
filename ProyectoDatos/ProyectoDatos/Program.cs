using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0, j = 24, c = 45;
            byte variable = 250;
            char letra = 'a';
            decimal de = 0.8765m; //m o M
            float f = 0.5f, miFloat;// F o f;
            double d = 0.12312d;//D o d 
            string cadena = "123";
            bool semaforo = true;//True o false
            dynamic var = 23;
            DateTime fecha = DateTime.Today;

            Console.WriteLine("El valor de i es:{0} y de variable es:{1}", i, variable);
            Console.WriteLine("El valor decimal con 2 decimales es {0:F2}", de);
            Console.WriteLine("La fecha de hoy es " + fecha.ToShortDateString());
            Console.WriteLine("El valor de semaforo es: " + semaforo.ToString());

            //Conversión implicita            
            f = j;
            Console.WriteLine("f:{0:F2}",f);

            //Conversion explicita
            d = (double)c;
            Console.WriteLine("d:"+d);

            i = Convert.ToInt32(cadena);
            Console.WriteLine("i:"+i);

            //miFloat = (float)Convert.ToDouble(Console.ReadLine());

            */
            ///Proyecto promedio
            string name;
            float n1, n2, n3, n4, average;

            Console.WriteLine("Dame tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Dame una nota:");
            n1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame otra nota:");
            n2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame otra nota de nuevo:");
            n3 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame la útima nota:");
            n4 = (float)Convert.ToDouble(Console.ReadLine());

            average = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Hola {0}. \nTu nota media es de {1} puntos",name,average);
























            //End
            Console.ReadKey();
        }
    }
}
