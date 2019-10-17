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
            int numNotes;
            float num1, num2, num3, num4, result, add=0.0f;
            string name = string.Empty, message = string.Empty;
            //login
            Console.WriteLine("Dime tu nombre:(María/Pablo)"); 
            name = Console.ReadLine().ToLower();

            if (!(name == "maria" || name == "maría" || name == "pablo" || name=="xavi"))
            {
                Console.WriteLine("No estás autorizado a esta función");
            }
            else
            {
                //get the results
                //Console.WriteLine("Intro un num porfi");
                //num1 = (float)Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Intro un num porfi");
                //num2 = (float)Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Intro un num porfi");
                //num3 = float.Parse(Console.ReadLine());
                //Console.WriteLine("Intro un num porfi");
                //num4 = (float)Convert.ToDouble(Console.ReadLine());
                //result = (num1 + num2 + num3 + num4) / 4.0f;
                //Console.WriteLine("Resultado:" + result);


                //get the results by fori
                Console.WriteLine("Hola {0}. ¿Cuantas notas quieres introducir?",name);
                numNotes= Convert.ToInt32(Console.ReadLine());

                result = 0.0f;
                for (int i = 1; i <= numNotes; i++)
                {
                    Console.WriteLine("Intro un num porfi");
                    num1 = (float)Convert.ToDouble(Console.ReadLine());
                    add += num1;
                }
                result += add/ numNotes;
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
