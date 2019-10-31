using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearDigitoControl
{
    class Account
    {
        private string _AccountNumber;

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        private string AccountNumber { get => _AccountNumber; set => _AccountNumber = value; }

        private string Generator()
        {
            Random rnd = new Random();
            string output = string.Empty;
            //Cuatro primeros dígitos: código de la entidad financiera asignado por el Banco de España.
            for (int i = 0; i < 4; i++)
            {
                output += Random(rnd);
            }
            //Cuatro siguientes dígitos (posiciones 5 a 8): código de oficina de la entidad financiera en la que se haya formalizado el contrato.
            for (int i = 0; i < 4; i++)
            {
                output += Random(rnd);
            }
            //Dos dígitos siguientes (posiciones 9 y 10): <!--código de control-->, un algoritmo matemático que da validez e integridad al número de cuenta.







            //Últimos 10 dígitos: número de cuenta interno, asignado por la entidad y a su libre criterio de clasificación y control.
            for (int i = 0; i < 10; i++)
            {
                output += Random(rnd);
            }
            return output;
        }

        private int Random(Random rnd) { return rnd.Next(-1, 10); }
    }
}
