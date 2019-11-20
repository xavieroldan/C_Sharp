using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHErenciaIII
{
    class ClsPersona
    { //propiedades protected 
        protected string _Nombre;
        protected string _Apellido;
        protected string _Correo;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Correo { get => _Correo; set => _Correo = value; }

        //constructor
        public ClsPersona(string n, string a,string c) {
            Nombre=n; 
            Apellido = a;
            Correo = c; }
        public virtual  string VerInfo() { 
            
            return Nombre +"" +Apellido+""+Correo; }


    }
}
