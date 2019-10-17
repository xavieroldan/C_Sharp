using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fori
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string chain = "Hello World";
            
            
            //easy
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Vas por la iteración {0}",i);
            }


            //letters
            for (letter = 'a'; letter <='z' ; letter++)
            {
                Console.WriteLine("Vas por la letra {0}",letter);
            }

            //nested
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1 ; k <=4; k++)
                {
                    Console.WriteLine("Valor de j {0}. Valor de k {1}",j,k);
                }
            }

            //foreach

            foreach (char letter2 in chain)
            {
                Console.WriteLine(letter2);
            }








            //End
            Console.ReadKey();
        }
    }
}
