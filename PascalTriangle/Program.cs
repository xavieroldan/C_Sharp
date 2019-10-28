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
            double x = 0, y = 0, yAnt;
            int value, margin = 3, posY, posX = 0, memPosY;// x = row , y = column

            Console.WriteLine("¿Cuentas filas quieres?");
            value= Convert.ToInt32(Console.ReadLine());
            posY = (10 / 3) * value;

            DateTime timeStart = DateTime.Now;
            //Start 

            Console.Clear();
            for (int i = 1; i <= value; i++)
            {
                yAnt = y;
                y = 0;
                Console.SetCursorPosition(posY, Convert.ToInt32(x));
                memPosY = posY-margin;
                for (int j = 1; j <= yAnt + 1; j++)
                {  
                    Console.SetCursorPosition(memPosY,posX);
                    Console.Write((factorial(x)) / (factorial(y) * (factorial(x - y))));
                    y++;
                    memPosY += 2*margin;
                }
                posY -= margin;
                posX = Convert.ToInt32(++x);                     
                Console.Write("\n");
            }

            //End crono
            DateTime timeEnd = DateTime.Now;
            TimeSpan timeExpend = new TimeSpan(timeEnd.Ticks - timeStart.Ticks);
            Console.WriteLine("{0:F2} Miliseconds", timeExpend.TotalMilliseconds);

            //End
            Console.ReadKey();
        }

        static double factorial(double n)
        {
            if (n == 0) { return 1; }
            return n * factorial(n - 1);
        }        
    }
}
