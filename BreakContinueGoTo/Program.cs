using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinueGoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Break
            for (int i = 1; i < 10; i++)
            {
                if (i == 5) { break; }
                Console.WriteLine(i);
            }

            //Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 5) { continue; }
                Console.WriteLine(i);
            }

            //Goto
            for (int i = 1; i < 10; i++)
            {
                if (i == 5) { goto myAction1; }
                if (i == 6) { goto myAction2; }
                Console.WriteLine(i);
            }

        myAction1: 
            
            Console.WriteLine("Vengo del goto 1");

        myAction2:

            Console.WriteLine("Vengo del goto 2");

            //End
            Console.ReadKey();
        }
    }
}
