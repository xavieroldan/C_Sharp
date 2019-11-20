using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHErenciaIII
{
    class ClsEstudiante : ClsPersona
    {   private int _Codigo;
        private string _Facultad;
        public ClsEstudiante(string name, string apell, string mail, int codi, string f) : base(name, apell, mail)
        {
            Codigo = codi;
            Facultad= f;
        }

        public int Codigo { get => _Codigo; set => _Codigo = value; }
        public string Facultad { get => _Facultad; set => _Facultad = value; }
        public override string VerInfo() {
            return base.VerInfo()+""+Codigo+""+Facultad; 

             }
    }
}
