using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHErenciaIII
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsEstudiante estudiante1 = new ClsEstudiante("Laura","Martinez","s@gmail.com",12346,"UB");
            Console.WriteLine(estudiante1.VerInfo());//da problemas por el protected
            Console.ReadKey();
        }
    }
}
