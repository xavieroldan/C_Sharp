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

            //My code here
            Thread.Sleep(2000);

            DateTime timeEnd = DateTime.Now;
            TimeSpan timeExpend = new TimeSpan(timeStart.Ticks - timeEnd.Ticks);

            Console.WriteLine(timeExpend.ToString());
            Console.ReadKey();
        }
    }
}
