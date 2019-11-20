using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseSealed
{
    sealed class FinalCubo : Rectangulo
    {
        public FinalCubo(int l1, int l2) : base(l1,l2)
        { 
            this.Lado1 = l1;
            this.Lado2 = l2;
        }


    }
}
