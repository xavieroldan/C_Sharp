using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Functions
            int num1 = 2, num2 = 3;

            Console.WriteLine("El cuadrado de {0} es: {1}",num1,Cuadrado(num1));

            Console.WriteLine("La potencia de 7 a la 8 es:" + myPow(7,8));
            Console.WriteLine("Mi raíz cuadrada de 2 es:"+mySqr());




            //End
            Console.ReadKey();


        }
        
        static int Cuadrado(int num) { return num * num; }

        //Pow
        static double myPow (int num, int pot)
        {
            return Math.Pow(num,pot);
        }

        //Sqr no arguments
        static double mySqr()
        {
            return Math.Sqrt(2);
        }

    }
}
