using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pascal triangle
            int x=0, y=0, yAnt, value=6; // x = row , y = column

            for (int i = 1; i <= value; i++)
            {
                yAnt = y;
                y = 0;
                for (int j = 1; j <= yAnt + 1; j++)
                {
                    Console.WriteLine((factorial(y)) / (factorial(x) * (factorial(x - y))));
                        y++;
                }
                x++;
            }



        //End
        Console.ReadKey();
        }

        static int factorial(int n)
        {
            if (n == 0) { return 1; }
            return n * factorial(n - 1);
        }
    }
}
