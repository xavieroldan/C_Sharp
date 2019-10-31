using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearCtaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            TitularController controller = new TitularController();

            Console.WriteLine("Simulador de llamadas formulario titular:");

            
            //POST error name short
            FormDTO case2 = new FormDTO(
                "a", "123456789B", "Corriente");
            controller.verifyTitular(case2);

            //POST error DNI number
            FormDTO case3 = new FormDTO(
                "Juan", "0B", "Corriente");
            controller.verifyTitular(case3);

            //POST error DNI letter
            FormDTO case4 = new FormDTO(
                "Juan", "123456789Z", "Corriente");
            controller.verifyTitular(case4);

            //POST 200-OK
            FormDTO case5 = new FormDTO(
                "Juan", "123456789B", "Corriente");
            controller.verifyTitular(case5);

            Console.ReadKey();
        }
    }
}
