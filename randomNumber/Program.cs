using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int rndNumber;
            Random rnd = new Random();
            bool isExiting = false;
            string exit;

            while (!isExiting)
            {
            
            Console.WriteLine("Dime un número del 1 al 9:");
            input = Convert.ToInt32(Console.ReadLine());

            rndNumber= rnd.Next(1, 9);

            if(rndNumber==input)
            {
                Console.WriteLine("Acertaste!");       
            }
            else
            {
                Console.WriteLine("Oh! No lo adivinaste...");
            }

            Console.WriteLine("Elegiste {0} y salió {1}",input,rndNumber);

                //Exit menu


                Console.WriteLine("S para salir / otra opción para continuar");
                exit = Console.ReadLine();

                if (exit.ToLower()=="s")
                {
                    isExiting = true;
                }
            }
        }
    }
}
