using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //numero = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Suma del número y sus sucesivos..."+calculoSuma(numero));

            //Factorial
            //Console.WriteLine("Cálculo del factorial. Dame el número:");
            //numero = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Factorial de "+numero+": "+ calculoFactorial(numero));

            /*
             Crea una función que calcule el valor de elevar un número entero a otro
            número entero (por ejemplo, 5 elevado a 3 = 5^3 = 5 • 5 • 5 = 125). Esta
            función se debe crear de forma recursiva. Piensa cuál será el caso base
            (qué potencia se puede calcular de forma trivial) y cómo pasar del caso
            "n-1" al caso "n" (por ejemplo, si sabes el valor de 54
            , cómo hallarías el
            de 55 a partir de él).
             */

            //int a, b;
            //Console.WriteLine("Dame el valor a elevar:");
            //a= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dame la potencia:");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Potencia de {0} a la {1} : {2}",a,b,myPow(a,b));
            //Console.WriteLine("Con Math.Pow : "+Math.Pow(a,b));

            /*
             - Crea un programa que emplee recursividad para calcular un número de
                la serie Fibonacci (en la que los dos primeros elementos valen 1, y para
                los restantes, cada elemento es la suma de los dos anteriores).
                Consideramos el inicio en 1,2,3,5,8....
             */

            //int pos = 5;
            //Console.WriteLine("Fibo de la posición {0} considerando la secuencia 1,2,3,5,8...: {1}",pos, calculoFibonacci(pos));


            ////Pares
            //Console.WriteLine("Lista de pares:");
            //Console.WriteLine("Resultado:"+pares(5));

            ////MyProgress

            //Console.WriteLine("->"+myProgress(4));

            //
            for (int i = 1; i <= 18; i++)
            {
                Console.WriteLine("Euler precisión {0}: {1}",i, eulerNum(i));
            }
            

            Console.ReadKey();
        }

        static int calculoSuma(int n)
        {
            if(n==1) { return 1; }
            Console.WriteLine("el valor de n es "+n);
            return n + calculoSuma(n - 1);
        }
        static double calculoFactorial(double n)
        {
            if (n == 1) { return 1; }
            //Console.WriteLine("el valor de n es " + n);
            return n * calculoFactorial(n - 1);
        }

        static int myPow(int a, int b)
        {
            if (b == 0) { return 1; }
            return a * myPow(a, b - 1);
        }

        static int calculoFibonacci(int n)
        {            
            if (n == 1 || n == 0) { return 1; }
            return calculoFibonacci(n - 1) + calculoFibonacci(n - 2);
        }

        static int pares (int n)
        {
            if (n == 1) { return 2;}            
            return 2 + pares(n - 1);
        }

        static int myProgress (int n)
        {
            if(n == 1) { return 1; }
            return myProgress(n - 1) * 2;
        }

        static double eulerNum (double n)
        {
            if (n == 1) { return 1; }
            return (1 / calculoFactorial((n - 1))) + eulerNum (n - 1);
        }

    }
}
