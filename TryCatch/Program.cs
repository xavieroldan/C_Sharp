using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cálculo precio / cantidad      
            int num = 0; ;
            int price=0 ;
            bool isError = false;

            try
            {
                Console.WriteLine("Dame la cantidad del producto:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el precio del producto:");
                price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divididos:"+(num/price));
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Ha ocurrido un error al dividir->" + e.Message);
                isError = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha ocurrido un error general->"+e.Message);
                isError = true;
            }

            if(!isError) { Console.WriteLine("El precio de la compra es {0:F2}", num * price); }
            









            //End
            Console.ReadKey();

        }
    }
}
