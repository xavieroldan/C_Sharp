using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearCtaBancaria
{
    class Titular
    {
        private string _Name= string.Empty;
        private string _Dni= string.Empty;
        private string _AccountType = "Corriente";

        public Titular()
        { }

        public Titular(string name, string dni, string accountType)
        {
            Name = name;
            Dni = dni;
            AccountType = accountType;
        }

        public string Name { get => _Name; set => _Name = value; }
        public string Dni { get => _Dni; set => _Dni = value; }
        public string AccountType { get => _AccountType; set => _AccountType = value; }
    }
}
