using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de 10 alumnos con 10 notas
            //Salida del primer y último alumno con su nota

            //String output = string.Empty;
            //String[] nameList = new string[10];
            //double[] noteList = new double[10];
            //int n;
            //double avg = 0.0d, max = 0.0;

            //Console.WriteLine("Lista de alumnos con su nota:");
            //Console.WriteLine("¿Cuantos alumnos tienes?");
            //n = Convert.ToInt32(Console.ReadLine());
            //Array.Resize(ref nameList, n);
            //Array.Resize(ref noteList, n);

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Nombre {0}:",i);
            //    nameList[i] = Console.ReadLine();
            //    Console.WriteLine("Nota {0}:", i);
            //    noteList[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //output += "Primero:" + nameList[0] + "/" + noteList[0] +
            //    "\nÚltimo:" + nameList[n-1] + "/" + noteList[n-1];
            //Console.WriteLine(output);


            ////Nota media de la clase
            //for (int i = 0; i < noteList.Length; i++)
            //{
            //    avg += noteList[i];
            //}
            //avg /= noteList.Length;
            //Console.WriteLine("Nota media: {0:F2}", avg);

            ////Nota máxima
            //for (int i = 0; i < noteList.Length; i++)
            //{
            //    if(noteList[i]>max) { max = noteList[i]; }
            //}
            //Console.WriteLine("Nota máxima: {0}",max);

            ////Lista de los que tienen la nota máxima
            //output = string.Empty;

            //for (int i = 0; i < nameList.Length; i++)
            //{
            //    if(noteList[i] == max) { output += "\n["+nameList[i]+"]"; }
            //}

            //Console.WriteLine("Los alumnos con nota máxima son:"+output);

            //Resultado de una prueba con el DNI

            //string[] candidates = { "11111111z", "123456789a", "987654321a" };
            //bool[] result = { false, true, false };
            //string dni = string.Empty;
            //bool isAprobed = false, isExaminated=false;

            //Console.WriteLine("Indica tu DNI para saber la nota:");
            //dni = Console.ReadLine();

            //for (int i = 0; i < candidates.Length; i++)
            //{
            //    if(candidates[i] == dni) 
            //    { 
            //        isAprobed = result[i];
            //        isExaminated = true;
            //        break; // is UK and break the search
            //    }
            //}
            //if(isAprobed)
            //{
            //    Console.WriteLine("Aprobado");
            //}
            //else if(isExaminated)
            //{
            //    Console.WriteLine("Supendido");
            //}
            //else
            //{
            //    Console.WriteLine("No estás en el sistema");
            //}

            //Poner en un array los númros del 1 al 100 
            //Los pares ponerlos en otro array

            int[] oneHundred = new int [100], pairs = new int[0];
            int pairIndex = 0;
            
            for (int i = 0; i < 100; i++)
            {
                oneHundred[i] = i + 1;
                if (oneHundred[i] % 2 == 0) 
                {
                    Array.Resize(ref pairs, pairs.Length + 1); // Auto increment the array size
                    pairs[pairIndex++] = oneHundred[i]; //Add the data and increment the index of pairs
                }
            }
            Console.WriteLine("Los pares son:");
            foreach (var item in pairs)
            {
                Console.Write("["+item+"]");
            }
            Console.WriteLine("\nEl primer par es {0} y el penúltimo {1}",pairs[0], pairs[pairs.Length-2]);
            //End
            Console.ReadKey();
        }
    }
}