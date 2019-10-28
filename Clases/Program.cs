using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            //Window myWindow = new Window();
            //myWindow.maximizar();
            //Console.WriteLine("La altura es:", myWindow.height);
            ////cambio desde la instancia de la clase
            //myWindow.width = 25;

            //clsCirculo circulo1 = new clsCirculo();
            //circulo1.radio = 5;
            //Console.WriteLine("El área de mi circulo es {0:F2}",circulo1.calcularArea());

            clsCuentaBancaria myCuenta = new clsCuentaBancaria();
            // ver el saldo
            Console.WriteLine(myCuenta.mostrarSaldo());
            //ingresar saldo
            myCuenta.ingresarSaldo(1000);
            //ver el saldo
            Console.WriteLine(myCuenta.mostrarSaldo());
            //sacar saldo
            myCuenta.sacarSaldo(500);
            Console.WriteLine(myCuenta.mostrarSaldo());
            //cambiar tipo a plazo fijo
            myCuenta.tipo = "Plazo fijo";
            Console.WriteLine(myCuenta.tipo);

            //End
            Console.ReadKey();
        }
    }

    class Window
    {
        //Attributes 
        public int width = 15;
        public int height = 20;
        public string color = "rojo";

        //Constructor
        public Window() { }

        //Methods
        public void cerrar() 
        {
            this.width = 20; //Acceso desde la misma clase
            Console.WriteLine("La ventana se cerró."); 
        }
        public void maximizar() { Console.WriteLine("La ventana se maximizó."); }

    }
}
