using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasClases
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = string.Empty;
            bool isExiting = false;
            double bas = 0.0d, alt = 0.0d;

            Console.WriteLine("Figuras:");
            while (!isExiting)
            {
                Console.WriteLine("\nElige que figura quieres:"
                + "\n1-Circulo"
                + "\n2-Triángulo"
                + "\n3-Rectángulo"
                + "\n4-Salir");
                option=Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\nCirculo:\n");
                        Console.WriteLine("Indica el radio:");
                        Circulo myCirculo = new Circulo(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("--->Su area es de {0}",myCirculo.CalcArea());   
                        break;

                    case "2":
                        Console.WriteLine("\nTriángulo:\n");
                        Console.WriteLine("Indica la base:");
                        bas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Indica la altura:");
                        alt = Convert.ToDouble(Console.ReadLine());
                        Triangulo myTriangulo = new Triangulo(bas, alt);
                        Console.WriteLine("--->Su area es de {0}", myTriangulo.CalcArea());
                        break;

                    case "3":
                        Console.WriteLine("\nRectángulo:\n");
                        Console.WriteLine("Indica la base:");
                        bas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Indica la altura:");
                        alt = Convert.ToDouble(Console.ReadLine());
                        Rectangulo myRectangulo = new Rectangulo(bas, alt);
                        Console.WriteLine("--->Su area es de {0}", myRectangulo.CalcArea());
                        break;

                    case "4":
                        Console.WriteLine("Espero verte pronto!!!");
                        Console.ReadKey();
                        isExiting = true;
                        break;

                    default:
                        Console.WriteLine("Elige una opción correcta (1-2-3)");
                        isExiting = false;
                        break;
                }    
            }
            
        }
    }
}
