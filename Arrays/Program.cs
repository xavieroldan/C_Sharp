using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays -> all the same type

            //Initialize
            int[] vector = new int[5];
            string[] elementsString = new string[4];
            int[] myArray = new int[] { 1, 3, 5, 6, 7 };
            string[] week = new string[] { "L", "M", "X", "J", "V", "S", "D" };

            //Setting
            for (int i = 0; i <5 ; i++)
            {
                vector[i] = i;
            }

            Console.WriteLine("El cuarto elemento es "+vector[3]);
            //number
            char letter = 'a';
            for (int i = 0; i < 4; i++)
            {
                elementsString[i] = Convert.ToString(letter);
                letter++;
            }
            //string
            string output = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                output+= "["+elementsString[i] + "]";
            }
            Console.WriteLine(output);

            
            
            
            
            
            
            
            
            
            //End
            Console.ReadKey();
        }
    }
}
