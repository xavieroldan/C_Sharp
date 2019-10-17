using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factorial de un número
            int num, fact = 1; ;

            Console.WriteLine("Factorial de un número\nIntroduce un número entero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact *= i;                
            }
            Console.WriteLine("Solución: {0}",fact);

            //End
            Console.ReadKey();
        }
    }
}
