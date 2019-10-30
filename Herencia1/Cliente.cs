﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    internal class Cliente: Persona
    {
        private int _IdCliente;
        private string _Empresa;
        private string _Ciudad;

        public Cliente(string nombre, string apellido, string dni, int idCliente, string empresa, string ciudad) : base(nombre, apellido, dni)
        {
            IdCliente = idCliente;
            Empresa = empresa;
            Ciudad = ciudad;
        }

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Empresa { get => _Empresa; set => _Empresa = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
    }
}
