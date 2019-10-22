using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList

            //ArrayList myArrayList = new ArrayList();           

            //myArrayList.Add(1);
            //myArrayList.Add("texto");
            //myArrayList.Add(true);
            //myArrayList.Add(Console.BackgroundColor);

            //IList myIlist = new ArrayList() //Interface where ArrayList behavior from
            //{
            //    100,200,true,"text"
            //};

            //myArrayList.AddRange(myIlist);

            //int myVar1 = Convert.ToInt32(myArrayList[0]);
            //string myVar2 = Convert.ToString(myArrayList[1]);
            //bool myVar3 = Convert.ToBoolean(myArrayList[2]);
            //var myVar4 = myArrayList[3];

            //foreach (var item in myArrayList)
            //{
            //    Console.WriteLine("Objeto: "+item);
            //}

            //Entrada de alumnos y notas en un ArrayList
            ArrayList classList = new ArrayList();
            double noteAvg = 0.0d;
            int count = 1, option;

            Console.WriteLine("Número de alumnos:");
            int size= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Nombre alumno:");
                classList.Add(Console.ReadLine());
                Console.WriteLine("Nota:");
                classList.Add(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine("Elige un alumno para saber su nota:");
            foreach (var item in classList)
            {
                
                if(item is Double)
                { 
                    noteAvg += Convert.ToDouble(item);
                }
                else
                {
                    Console.WriteLine(count+"-"+item);
                    count++;
                }
            }
            noteAvg /= size;
            Console.WriteLine("La media de notas es de: {0:F2}",noteAvg);
            option = Convert.ToInt16(Console.ReadLine());

            count = 0;
            foreach (var item in classList)
            {
                if(item is String)
                {                    
                    count++;
                }
                else if(count == option)
                {
                    Console.WriteLine("Nota:"+item);
                }
            }

            //End
            Console.ReadKey();
        }
    }
}
