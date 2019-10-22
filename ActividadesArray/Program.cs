using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main menu
            
        mainMenu:;
            Console.WriteLine("Elige el ejercicio que quieres hacer pulsando el número:");
            Console.WriteLine("1-Múltiplos");
            Console.WriteLine("2-Alumnos trimestre");
            Console.WriteLine("3-Subida de suledo");
            Console.WriteLine("4-Salir");
            try
            {
                var option = Console.ReadKey();
                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        goto sub1;
                    case ConsoleKey.D2:
                        goto sub2;
                    case ConsoleKey.D3:
                        goto sub3;
                    case ConsoleKey.D4:
                        goto end;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                goto mainMenu;
            }
            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            goto mainMenu;

        // 1 - Ens entren n números , es necessiten desar i dir quants són múltiples de 5 i quants són
        // múltiples de 7. (Tenir en compte que un número pot ser tant múltiple de cinc com de
        // 7)

        sub1:;
            int cant = 0, num, mult5 = 0, mult7 = 0, multBoth = 0;
            int[] numList = new int[0];
            
            Console.WriteLine("Múltiplos de 5 y 7\n");

            repeat1:;
            Console.WriteLine("Indica el número de entradas:");
            try
            {
                cant = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto repeat1;
            }

            Array.Resize(ref numList, cant);

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine("Introduce el número {0}:", i + 1);
                numList[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numList.Length; i++)
            {
                if (numList[i] % 5 == 0)
                {
                    if (numList[i] % 7 == 0) { multBoth++; }
                    else { mult5++; }
                }
                else if (numList[i] % 7 == 0) { mult7++; }
            }
            Console.WriteLine("Múltiplos de 5: {0} \nMúltiplos de 7: {1} \nMúltiplos de ambos {2}", mult5, mult7, multBoth);

        //2 - Tenim un array amb la llista del 10 alumnes que hi ha a un curs.S’ha de desar les notes
        //de cada trimestre(són tres trimestres ) per a cada alumne. Donar la mitja final dels
        //trimestres del darrer alumne. 
        sub2:;
            string[] students = { "Pepe", "Ana", "Litus", "Jose", "Gabi", "Sonia", "Lourdes", "Alex", "Mathew", "Eric" };
            double[] trim1 = new double[10];
            double[] trim2 = new double[10];
            double[] trim3 = new double[10];
            double avg = 0.0d;

            Console.WriteLine("\nMedia nota trimestre alumnos\n");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Nota para el primer trimestre de {0}:", students[i]);
                trim1[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota para el segundo trimestre de {0}:", students[i]);
                trim2[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota para el tercer trimestre de {0}:", students[i]);
                trim3[i] = Convert.ToDouble(Console.ReadLine());
            }

            avg += trim1[trim1.Length - 1] + trim2[trim2.Length - 1] + trim3[trim3.Length - 1];
            avg /= 3;

            Console.WriteLine("El último alumno, {0}, tiene una media de: {1}", students[students.Length - 1], avg);

            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            goto mainMenu;
        //3 - Es tenen desats de manera interna els identificadors dels treballadors i a la vegada el
        //seu sou i els anys que porten treballant. Als que porten més de 3 anys tenen un
        //augment del 5 %.Actualitzar les dades del sou amb aquest augment.
        sub3:;
            string[] listEmployee = { "id1", "id2", "id3" };
            double[] salaries = { 1000, 2000, 3000 };
            int[] seniority = { 10, 1, 4 };

            Console.WriteLine("Subida sueldo empleados\n");

            for (int i = 0; i < seniority.Length; i++)
            {
                if (seniority[i] > 3) { salaries[i] *= 1.05d; }
            }
            Console.WriteLine("Sueldos actualizados:");

            for (int i = 0; i < salaries.Length; i++)
            {
                Console.WriteLine("Empleado: {0} \tAntigüedad:{1} años\tSueldo: {2}",listEmployee[i],seniority[i],salaries[i]);
            }

            Console.WriteLine("Pulsa una tecla para continuar.");
            Console.ReadKey();
            goto mainMenu;


        end:;
            Console.WriteLine("\nAdios!!!");
            Console.ReadKey();
        }
    }
}
