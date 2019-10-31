using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearCtaBancaria
{
    class TitularController
    {
        private Titular _Titular;
        private FormDTO _FormDTO;

        public TitularController()
        {
        }       

        internal Titular Titular { get => _Titular; set => _Titular = value; }
        internal FormDTO FormDTO { get => _FormDTO; set => _FormDTO = value; }

        public TitularDTO verifyTitular (FormDTO formDTO)
        {
            bool isVerified = false;
            string responseCode = string.Empty;
            Titular responseTitular = null;
            
            //verify void name
            if (formDTO.Name == string.Empty || formDTO.Name.Length <2 ) // null catch by front
            {
                //Error name               
                    Console.WriteLine("400-Error en el nombre. No se aceptan nombres vacíos o inferiores a 2 letras.");
                    responseCode = "400 - Error en el nombre.No se aceptan nombres vacíos o inferiores a 2 letras.";
                    isVerified = false;               
            }
            else
            {
                //Name verified :)
                //Check the DNI
                int number = Convert.ToInt32(formDTO.Dni.Substring(0, formDTO.Dni.Length-1)); // read the number
                char letter = Convert.ToChar(formDTO.Dni.Substring(formDTO.Dni.Length-1).ToUpper()); //read the letter

                //verify the number
                if(number<1)
                {
                    //Error number
                    Console.WriteLine("400-Error en el número del DNI. Indicar número superior a 0.");
                    isVerified = false;
                    responseCode = "Error en el número del DNI. Indicar número superior a 0.";
                }
                else
                {
                    //number verified :)
                    //verify the letter
                    string letterChecker = "TRWAGMYFPDXBNJZSQVHLCKE";
                    if (letter == letterChecker.ToCharArray().ElementAt(number % 23))
                    {
                        //Letter verified :)
                        Console.WriteLine("200-Creado el titular.");
                        isVerified = true;
                        responseCode = "200-Creado el titular.";
                        responseTitular = new Titular(formDTO.Name,formDTO.Dni,formDTO.AccountType);   
                    }
                    else
                    {
                        Console.WriteLine("400-Error en la letra del DNI.");
                        isVerified = false;
                        responseCode = "400-Error en la letra del DNI.";
                    }
                }                
            }
            return new TitularDTO( responseCode, isVerified, responseTitular);
        }
    }
}
