using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionesDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operand;
            float result=0.0f;
            string output = string.Empty, cadena = string.Empty;
            bool isExiting = false, isVerified = false;

           
                Console.WriteLine("Introduce un número:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                num2 = Convert.ToInt32(Console.ReadLine());




            //if(num1 >= num2)
            //{
            //    Console.WriteLine("El numero {0} es mayor o igual a {1}",num1,num2);
            //}
            //else 
            //{
            //    Console.WriteLine("El numero {0} es menor a {1}", num1, num2);
            //}

            //if (num1 > num2)
            //{
            //    Console.WriteLine("El numero {0} es mayor a {1}", num1, num2);
            //}
            //else if (num1 < num2)
            //{
            //    Console.WriteLine("El numero {0} es menor a {1}", num1, num2);
            //}
            //else
            //{
            //    Console.WriteLine("El numero {0} es igual a {1}", num1, num2);
            //}

            //Calculator exercise


            while (!isExiting)
            {
                output = "El resultado de la operación es: ";
                Console.WriteLine
                ("Indica la operación que quieres hacer:\n1-suma\n2-resta\n3-multiplicación\n4-división\n5-Salir");
                operand = Convert.ToInt32(Console.ReadLine());
                switch (operand)
                {
                    case 1:
                        //add
                        result = num1 + num2;
                        output +=num1+"+"+num2+"=";
                        break;
                    case 2:
                        //diff
                        result = num1 - num2;
                        output += num1 + "-"+num2 + "=";
                        break;
                    case 3:
                        //mult
                        result = num1 * num2;
                        output += num1 + "*"+num2 + "=";
                        break;
                    case 4:
                        //div
                        if (num2 != 0)
                        {
                            result = (float)num1 / (float)num2;
                            output += num1 + "/"+num2 + "=";
                        }
                        else
                        {
                            //div by zero error
                            result = 0;
                            output += "Error al dividir entre cero\n";
                        }
                        break;
                    case 5:
                        //exit
                        isExiting = true;
                        result = 0;
                        output += "Me cierro! Hasta pronto!\n";
                        break;

                    default:
                        //error operand
                        result = 0;
                        output += "Operación errónea. Indicar entre 1 y 4.\n";
                        break;
                }
                Console.WriteLine(output += result);


                //Ternary conditional
                cadena = (num1 > 0) ? "mayor que cero" : (num1 == 0) ? "igual a cero" : "menor que cero";
                Console.WriteLine("\nnumero 1 " + cadena);

                cadena = string.Empty;
                cadena += (num2 > 0) ? "mayor que cero" : (num1 == 0) ? "igual a cero" : "menor que cero";
                Console.WriteLine("\nnumero 2 " + cadena);
            }
            
            //End
            Console.ReadKey();            
        }
    }
}
