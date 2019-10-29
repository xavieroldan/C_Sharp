using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    class ClsEmpleado
    {
        private string _Nombre;
        private double _SueldoDiario;
        private int _Age;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double SueldoDiario { get => _SueldoDiario; set => _SueldoDiario = value; }
        public int Age { get => _Age; set => _Age = value; }

        public ClsEmpleado(string nombre, double sueldoDiario, int age)
        {
            this.Nombre = nombre;
            this.SueldoDiario = sueldoDiario;
            this.Age = age;
        }

        public ClsEmpleado (string name, int age) : this ( name, 100, age) { }

        public double CalcularSueldo (int dias) { return this.SueldoDiario * dias; }
        
    }
}
