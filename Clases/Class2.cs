using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class clsCuentaBancaria
    {
        public string numero;
        public string titular;
        public string tipo;
        public double saldo;

        public void sacarSaldo(double importe) 
        {
            this.saldo -= importe; 
        }

        public double mostrarSaldo() 
        {
            return this.saldo;
        }

        public void ingresarSaldo (double importe)
        {
            this.saldo += importe;
        }

    }
}
