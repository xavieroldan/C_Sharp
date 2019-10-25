using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CronoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeStart = DateTime.Now;
            //Start 

            //My code here
            int n;
            Arra[] su

















            //End crono
            DateTime timeEnd = DateTime.Now;
            TimeSpan timeExpend = new TimeSpan(timeEnd.Ticks - timeStart.Ticks) ;
            Console.WriteLine("{0:F2} Miliseconds", timeExpend.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
