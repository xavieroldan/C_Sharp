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

            //While to infinite execution
            while (true)
            {
                //Generate future matrix
                matrixFuture = matrix;
                //Read the matrix

                //i row // j column

                for (int y = 0; y < n; y++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        //Search the position

                        if (x == 0 && y == 0 || x == n && y == 0 || x == 0 && y == n || x == n & y == n)
                        {
                            //Vertex
                            matrixFuture[x, y] = VertexChanges(x, y, matrix, spinClock);
                        }
                        else if (
                              x == 0 && (y != 0 || y != n)
                            || x == n && (y != 0 || y != n)
                            || y == 0 && (x != 0 || x != n)
                            || y == n && (x != 0 || x != n)
                                )
                        {
                            //Wall
                            matrixFuture[x, y] = WallChanges(x, y, matrix);
                        }
                        else
                        {
                            //Center
                            matrixFuture[x, y] = centerChanges(x, y, matrix, spinClock);
                        }

                                               
                    }
                }
                //Fill the present matrix
                matrix = matrixFuture;

                //Output the future matrix
                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 1) { Console.Write(cell); }
                        else { Console.Write("  "); }
                    }
                    Console.Write("\n");
                }

            }

        }
        static int centerChanges(int x, int y, int[,] matrixInput, int[,] spinClock)
        {
            int alive = 0, cellState = 0, memAlive=0;            
            //Read cell state
            cellState = matrixInput[x, y];
            
            //Count alive cells
            for (int i = 0; i < spinClock.Length; i++)
            {              
                alive = CountAlive(spinClock, x, y, i,matrixInput);
                memAlive += alive;
            }
            //Dead rules
            cellState = UpdateCellState(cellState, memAlive);
            return cellState;
        }

        static int VertexChanges(int x, int y, int[,] matrixInput, int [,] spinClock) 
        {
            // Matrix always is square
            int alive = 0, cellState = 0,memAlive =0;
            int n = matrixInput.GetLength(0);
            int[,] miniSpinClock = new int[3, 2] {
                {-1,0}
                , {-1, -1}
                , { 0,-1}
            };

            if (x == 0 && y == 0) 
            {
                //Top left
                for (int i = 3; i <= 5; i++)
                {                    
                    alive = CountAlive(spinClock, x, y, i, matrixInput);
                    memAlive += alive;
                }   
            }
            else if (x == n && y == 0)
            {
                //Top right
                for (int i = 5; i <= 7; i++)
                {
                    alive = CountAlive(spinClock, x, y, i, matrixInput);
                    memAlive += alive;
                }
            }
            else if (x == 0 && y == n)
            {
                //Bottom left
                for (int i = 1; i <= 3; i++)
                {
                    alive = CountAlive(spinClock, x, y, i, matrixInput);
                    memAlive += alive;
                }
            } 
            else
            {
                //Bottom right 
                //Sequence 7,0 and 1  __Error here? 
                for (int i = 0; i <= 2; i++)
                {
                    alive = CountAlive(miniSpinClock, x, y, i, matrixInput);
                    memAlive += alive;
                }
            }
            //Dead rules
            cellState = UpdateCellState(cellState, memAlive);
            return cellState;
        }

        static int WallChanges(int x, int y, int[,] matrixInput)
        {
            int alive = 0, cellState = 0, memAlive = 0;
            int n = matrixInput.GetLength(0);
            int[,] spinClock = new int[8, 2] {
                { -1,1}
                , { 0, 1}
                , { 1,1}
                , { 1,0}
                , { 1,-1}
                , { 0,-1}
                , { -1,-1}
                , { -1,0}
            };

            if (y == 0 && (x != 0 || x != n)) 
            { 
                //Top
                for (int i = 3; i <= 7; i++)
                {
                    alive = CountAlive(spinClock, x, y, i, matrixInput);
                    memAlive += alive;
                } 
            }
            else if(x == n && (y != 0 || y != n)) 
            {
                //Right 
                int[,] spinClockRight = new int[5, 2] {
                     { 0,-1}
                    , { -1,-1}
                    , { -1,0}
                    , { -1,1}
                    , { 0, 1}
                };
                for (int i = 0; i <= 4; i++)
                {
                    alive = CountAlive(spinClockRight, x, y, i, matrixInput);
                    memAlive += alive;
                }
            }            
            else if (y == n && (x != 0 || x != n))
            {
                 //Bottom
                 int[,] spinClockBottom = new int[5, 2] {
                       { -1,0}
                    , {-1,1}
                    , { 0,1}
                    , { 1,1}
                    , { 1,0}
                    };
                 for (int i = 0; i <= 4; i++)
                    {
                        alive = CountAlive(spinClockBottom, x, y, i, matrixInput);
                        memAlive += alive;
                    }
                }
            else 
            {
                //Left
                for (int i = 1; i <= 5; i++)
                {
                    alive = CountAlive(spinClock, x, y, i, matrixInput);
                    memAlive += alive;
                }
            }

            //Dead rules
            cellState = UpdateCellState(cellState, memAlive);
                return cellState;
            
        }

        static int CountAlive(int [,] spinClock, int x, int y, int i, int [,] matrixInput)
        {
            int alive = 0;
            int xToLook = spinClock[i, 0] + x;
            int yToLook = spinClock[i, 1] + y;
            if (matrixInput[xToLook, yToLook] == 1)
            {
                alive++;
            }
            return alive;
        }

        static int UpdateCellState(int cellState, int alive)
        {
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
    }

}

