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

            // 1 - Ens entren n números , es necessiten desar i dir quants són múltiples de 5 i quants són
            // múltiples de 7. (Tenir en compte que un número pot ser tant múltiple de cinc com de
            // 7)
            int cant = 0, num, mult5 = 0, mult7 = 0, multBoth = 0;
            int[] numList = new int[0];

            Console.WriteLine("Múltiplos de 5 y 7\n");
            Console.WriteLine("Indica el número de entradas:");
            cant = Convert.ToInt32(Console.ReadLine());

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

            //                3 - Es tenen desats de manera interna els identificadors dels treballadors i a la vegada el
            //seu sou i els anys que porten treballant. Als que porten més de 3 anys tenen un
            //augment del 5 %.Actualitzar les dades del sou amb aquest augment.

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

            //End
            Console.ReadKey();
            //
        }
    }
}
