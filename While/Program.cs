using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty, psw = string.Empty;
            int i = 0;

            //Basic
            //Console.WriteLine("Dame el nombre:");
            //name = Console.ReadLine();

            //while(name!="Laura")
            //{
            //    Console.WriteLine("Dame el nombre:");
            //    name = Console.ReadLine();
            //}
            //Console.WriteLine("Hola Laura!");

            //do while
            do
            {
                Console.WriteLine("Dame el nombre:");
                name = Console.ReadLine();


            } while (!(name == "Laura"||name =="Pablo"));
            Console.WriteLine("Hola {0}",name);
            do
            {
               Console.WriteLine("Dame el password:");
               psw = Console.ReadLine();                
                if (i == 3) { break; }
                i++;
            } while (psw!="1234");

            if(i == 3 && psw !="1234")
            {
                Console.WriteLine("Estás fuera del sistema.");
            }
            else
            {
                Console.WriteLine("Te has logeado");
            }
            






            //End
            Console.ReadKey();
        }
    }
}
