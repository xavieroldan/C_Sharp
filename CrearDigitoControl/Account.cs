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

        public Account()
        {
            AccountNumber = Generator();
        }

        private string AccountNumber { get => _AccountNumber; set => _AccountNumber = value; }

        private string Generator()
        {
            Random rnd = new Random();
            string output = string.Empty, entidad = string.Empty, oficina = string.Empty, cuenta = string.Empty;
            int dig1 = 0, dig2 =0;
            int [] pos1 = new int[8], pos2 = new int[10];

            
            //Cuatro primeros dígitos: código de la entidad financiera asignado por el Banco de España.
            for (int i = 0; i < 4; i++)
            {
                entidad += Random(rnd);
            }
            //Cuatro siguientes dígitos (posiciones 5 a 8): código de oficina de la entidad financiera en la que se haya formalizado el contrato.
            for (int i = 0; i < 4; i++)
            {
                oficina += Random(rnd);
            }

            //Últimos 10 dígitos: número de cuenta interno, asignado por la entidad y a su libre criterio de clasificación y control.
            for (int i = 0; i < 10; i++)
            {
                cuenta += Random(rnd);
            }

            //Dos dígitos siguientes (posiciones 9 y 10): <!--código de control-->, un algoritmo matemático que da validez e integridad al número de cuenta.

            pos1[0] = entidad[0] * 4;
            pos1[1] = entidad[1] * 8;
            pos1[2] = entidad[2] * 5;
            pos1[3] = entidad[3] * 10;
            pos1[4] = oficina[0] * 9;
            pos1[5] = oficina[1] * 7;
            pos1[6] = oficina[2] * 3;
            pos1[7] = oficina[3] * 6;

            for (int i = 0; i < 8; i++)
            {
                dig1 += pos1[i];
            }
            
            dig1 = VerifyDC(dig1);

            pos2[0] = cuenta[0] * 1;
            pos2[1] = cuenta[1] * 2;
            pos2[2] = cuenta[2] * 4;
            pos2[3] = cuenta[3] * 8;
            pos2[4] = cuenta[4] * 5;
            pos2[5] = cuenta[5] * 10;
            pos2[6] = cuenta[6] * 9;
            pos2[7] = cuenta[7] * 7;
            pos2[8] = cuenta[8] * 3;
            pos2[9] = cuenta[9] * 6;

            for (int i = 0; i < 8; i++)
            {
                dig2 += pos2[i];
            }

            dig2 = VerifyDC(dig2);

            output = entidad +"-"+ oficina +"-"+ dig1 + dig2 +"-"+ cuenta;
            return output;
        }

        private int Random(Random rnd) { return rnd.Next(10); }

        public string GetAccount()
        {
            return AccountNumber;
        }

        public int VerifyDC(int dig)
        {
            int tempDig = 11 - (dig % 11);
            if (tempDig == 10) { dig = 1; }
            else if (tempDig == 11) { dig = 0; }
            else { dig = tempDig; }
            return dig;
        }
    }
}
