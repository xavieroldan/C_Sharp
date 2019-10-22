using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a2 = new int[3, 4]; //2 dimensions
            int[,,] b3 = new int[4, 8, 9]; //3 dimensions
            int[][] c4 = new int[3][]; //not defined dimension

            Console.Title = "Hello Mundo";
            Console.BackgroundColor = ConsoleColor.Red;

            //Matrices "escalonadas"
            int[][] jaggedArray =
                {
                    new int[] { 1, 3, 5, 7, 9 },
                    new int[] { 0, 2, 4, 6 },
                    new int[] { 11, 22 }
                };

            //Read array
            int[,] myArray = new int [3, 4] { { 1, 2, 3, 4 } , { 5, 6, 7, 8 } , { 9, 10, 11, 12 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //Console.WriteLine(myArray[i, j]); 
                }
            }

            //Exercise 1
            int x, y;
            var rand = new Random();
            int colSize = 4;
            int rowSize = 2;
            int marginX = 25;
            int marginY = 5;

            Console.WriteLine("Dame filas:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame columnas:");
            y = Convert.ToInt32(Console.ReadLine());

            int[,] customArray= new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    customArray[i, j] = rand.Next(0,99);
                    Console.SetCursorPosition((colSize * j + marginX), (rowSize * i + marginY));
                    Console.Write(customArray[i, j]);
                }
            }

            
            //End
            Console.ReadKey();
        }
    }
}
