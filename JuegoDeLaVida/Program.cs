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
            Random rnd = new Random();
            string cell = "@ ";

            //---------------------------------Game of Life-------------------------------------
            //Matrix random fill
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

            //TODO: While to infinite execution

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
                        //TODO: Vertex
                        matrixFuture[x, y] = vertexChanges(x, y, matrix);

                    }
                    else if (
                          x == 0 && (y != 0 || y != n)
                        || x == n && (y != 0 || y != n)
                        || y == 0 && (x != 0 || x != n)
                        || y == n && (x != 0 || x != n)
                            )
                    {
                        //TODO: Wall
                    }
                    else
                    {
                        //Center
                        matrixFuture[x, y] = centerChanges(x, y, matrix, spinClock);
                    }

                    //ENd
                    Console.ReadKey();
                }
            }
        }
        static int centerChanges(int x, int y, int[,] matrixInput, int[,] spinClock)
        {
            int alive = 0, xToLook, yToLook, cellState = 0;            
            //Read cell state
            cellState = matrixInput[x, y];

            //Count alive cells
            for (int i = 0; i < spinClock.Length; i++)
            {
                //xToLook = spinClock[i, 0] + x;
                //yToLook = spinClock[i, 1] + y;
                //if (matrixInput[xToLook, yToLook] == 1)
                //{
                //    alive++;
                //}

                alive = countAlive(spinClock, x, y, i);
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

        static int vertexChanges(int x, int y, int[,] matrixInput, int [,] spinClock) 
        {
            // Matrix always is square
            int alive = 0, xToLook, yToLook, cellState = 0;
            int n = matrixInput.GetLength(0);  
            
            if (x == 0 && y == 0) 
            {
                //Top left
                for (int i = 3; i <= 5; i++)
                {
                    //xToLook = spinClock[j, 0] + x;
                    //yToLook = spinClock[j, 1] + y;
                    //if (matrixInput[xToLook, yToLook] == 1)
                    //    {
                    //        alive++;
                    //    }
                    alive = countAlive(spinClock, x, y, i);

                }   
            }
            else if (x == n && y == 0)
            {
                //Top right
                for (int i = 5; i <= 7; i++)
                {
                    alive = countAlive(spinClock, x, y, i);
                }
            }
            else if (x == 0 && y == n)
            {
                //Bottom left
                for (int i = 1; i <= 3; i++)
                {
                    alive = countAlive(spinClock, x, y, i);
                }
            } 
            else
            {
                //Bottom right 
                //Manual sequence 7,0 and 1                
            }
                return 0;
        }

        static int countAlive(int [,] spinClock, int x, int y, int i)
        {
            int xToLook = spinClock[i, 0] + x;
            int yToLook = spinClock[i, 1] + y;
            if (matrixInput[xToLook, yToLook] == 1)
            {
                alive++;
            }
            return alive;
        }
        
    }

}

