using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, result;
            string name = string.Empty, message = string.Empty;

            Console.WriteLine("Dime tu nombre:"); 
            name = Console.ReadLine().ToLower();

            if (!(name == "maria" || name == "maría" || name == "pablo"))
            {
                Console.WriteLine("No estás autorizado a esta función");
            }
            else
            {
                //get the results
                Console.WriteLine("Intro un num porfi");
                num1 = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Intro un num porfi");
                num2 = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Intro un num porfi");
                num3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Intro un num porfi");
                num4 = (float)Convert.ToDouble(Console.ReadLine());
                result = (num1 + num2 + num3 + num4) / 4.0f;
                Console.WriteLine("Resultado:" + result);

                //Check aprovate
                message = (result >= 5) ? message = "aprobado" : message = "suspendido";
                
                Console.WriteLine("{0}. Has {1} con una nota de {2}", name, message, result);
            }
                //End
                Console.ReadKey();
            }
        }
    }
