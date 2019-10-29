using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    class ClsEmpleado
    {
        public string nombre;
        public double sueldoDiario;
        public int age;

        public ClsEmpleado(string nombre, double sueldoDiario, int age)
        {
            this.nombre = nombre;
            this.sueldoDiario = sueldoDiario;
            this.age = age;
        }

        public ClsEmpleado (string name, int age) : this ( name, 100, age) { }

        public double CalcularSueldo (int dias) { return this.sueldoDiario * dias; }
        
    }
}
