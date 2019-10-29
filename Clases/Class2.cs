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

        public clsCuentaBancaria(string nombre, int saldoInicial)
        {
            this.numero = Guid.NewGuid().ToString();
            this.titular = nombre;
            this.tipo = "corriente";
            this.saldo = saldoInicial;
        }

        public clsCuentaBancaria(string numero, string titular, string tipo, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.tipo = tipo;
            this.saldo = saldo;
        }



        public void SacarSaldo(double importe) 
        {
            this.saldo -= importe; 
        }

        public double MostrarSaldo() 
        {
            return this.saldo;
        }

        public void IngresarSaldo (double importe)
        {
            this.saldo += importe;
        }

    }
}
