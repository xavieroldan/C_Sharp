using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            
            //-------------------------Stack-------------------------------
            Stack myPila = new Stack();
            Object O = new Object();
            myPila.Push("hola");
            myPila.Push("que");
            myPila.Push("tal");
            myPila.Push(O);
            myPila.Push(123.05f);
            Console.WriteLine("Dato del top:"+myPila.Peek());

            foreach (var item in myPila.ToArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myPila.Contains("hola"));

            Console.WriteLine("Cuento los elementos de la pila:"+myPila.Count);
            //int count = myPila.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    word = (string)myPila.Pop();
            //    Console.WriteLine(word);
            //}   

            foreach (var item in myPila.ToArray())
            {
                myPila.Pop();
            }

            Console.WriteLine("Elementos en la pila:"+myPila.Count);

            Console.WriteLine("Hay elementos en la posición 1?"+myPila.Contains("hola")); //true false

            //-----------------------Colas -------------------
            Queue myCola = new Queue();

            myCola.Enqueue("hola");
            myCola.Enqueue("que");
            myCola.Enqueue("tal");
            myCola.Enqueue(O);
            myCola.Enqueue(123.05f);

            Console.WriteLine("Número de elementos:"+myCola.Count);
            Console.WriteLine("Valor del top:"+myCola.Peek());
            foreach (var item in myCola)
            {
                Console.WriteLine("valor:"+item);
            }
            
            Console.WriteLine("Borro el primero:"+myCola.Dequeue());

            while (myCola.Count > 0) { Console.WriteLine(myCola.Dequeue()); }

            Console.WriteLine("Número de elementos:" + myCola.Count);














            //End
            Console.ReadKey();
        }
    }
}
