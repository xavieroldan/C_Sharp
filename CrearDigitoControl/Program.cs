﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearDigitoControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            Console.WriteLine(myAccount.GetAccount());
            Console.ReadKey();
        }
    }
}
