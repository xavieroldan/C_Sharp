using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLaVida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[,] matrix = new int[n, n];
            int[,] matrixFuture = new int[n, n];
            Random rnd = new Random();
            string cell = "@ ";

            //Game of Life
            //Matrix random full
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 2);

                    if (matrix[i, j] == 1) { Console.Write(cell); }
                    else { Console.Write("  "); }
                }
                Console.Write("\n");
            }

            //While

            //Generate future matrix
            matrixFuture = matrix;
            //Read the matrix
            //i row // j column

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    //Search the borders

                    if (x == 0 && y == 0 || x == n && y == 0 || x == 0 && y == n || x == n & y == n)
                    {
                        //Vertex


                    }
                    else if (
                          x == 0 && (y != 0 || y != n)
                        || x == n && (y != 0 || y != n)
                        || y == 0 && (x != 0 || x != n)
                        || y == n && (x != 0 || x != n)
                            )
                    {
                        //Wall

                    }
                    else
                    {
                        //Center
                        matrixFuture[x, y] = centerChanges(x, y, matrix);
                    }


                    //ENd
                    Console.ReadKey();
                }
            }
        }
        static int centerChanges(int x, int y, int[,] matrixInput)
        {
            int alive = 0, xToLook, yToLook, cellState = 0;
            int[,] spinClock = new int[8, 2] {
                {-1,-1}
                , {0, -1}
                , { 1,-1}
                , { 1,0}
                , { 1,1}
                , { 0,1}
                , { -1,1}
                , { -1,0}
            };
            //Read cell state
            cellState = matrixInput[x, y];

            //Count alive cells
            for (int i = 0; i < spinClock.Length; i++)
            {
                xToLook = spinClock[i, 0] + x;
                yToLook = spinClock[i, 1] + y;
                if (matrixInput[xToLook, yToLook] == 1)
                {
                    alive++;
                }
            }
            //Dead rules
            if (cellState == 1)
            {
                //Alive rules

                //1st rule -> alive around <2 = dead
                if (alive < 2)
                {
                    cellState = 0; //dead
                }
                //2st rule -> 2 or 3 alive = live
                else if (alive == 2 || alive == 3)
                {
                    cellState = 1; // live
                }
                //3st -> alive > 3 = dead;
                else
                {
                    cellState = 0; //dead
                }
            }
            else
            {
                //Dead rules
                //1st -> 3 alive around = resurrects
                if (alive == 3)
                {
                    cellState = 1; // live 
                }
            }
            return cellState;
        }

        static int vertexChanges(int x, int y, int[,] matrix) 
        {

            return 0;
        }
    }

}

