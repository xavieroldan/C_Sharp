using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearCtaBancaria
{
    class TitularDTO
    {        
        private string _ResponseCode;
        private bool _isCreated= false;
        private Titular _Titular;

        public TitularDTO(string responseCode, bool isCreated, Titular titular)
        {
            ResponseCode = responseCode;
            IsCreated = isCreated;
            Titular = titular;
        }

        public string ResponseCode { get => _ResponseCode; set => _ResponseCode = value; }
        public bool IsCreated { get => _isCreated; set => _isCreated = value; }
        internal Titular Titular { get => _Titular; set => _Titular = value; }
    }
}
