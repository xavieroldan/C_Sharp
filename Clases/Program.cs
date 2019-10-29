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

            //clsCirculo circulo1 = new clsCirculo(5);
            //circulo1.radio = 5;
            //Console.WriteLine("El área de mi circulo es {0:F2}", circulo1.calcularArea());

            //clsCuentaBancaria myCuenta = new clsCuentaBancaria();
            //// ver el saldo
            //Console.WriteLine("Tu saldo es :"+myCuenta.MostrarSaldo());
            ////ingresar saldo
            //myCuenta.IngresarSaldo(1000);
            ////ver el saldo
            //Console.WriteLine("Tu saldo es :"+myCuenta.MostrarSaldo());
            ////sacar saldo
            //myCuenta.SacarSaldo(500);
            //Console.WriteLine("Tu saldo es :"+myCuenta.MostrarSaldo());
            ////cambiar tipo a plazo fijo
            //myCuenta.tipo = "Plazo fijo";
            //Console.WriteLine("Tu tipo de cuenta es :"+myCuenta.tipo);


            //ventanas
            //Window ventana1 = new Window();
            //Window ventana2 = new Window(20,30,"verde");
            //Window ventana3 = new Window(25);

            //Cuenta por defecto
            clsCuentaBancaria cuenta2 = new clsCuentaBancaria("Pepe",1);
            Console.WriteLine
                (
                    "ID: "+cuenta2.numero.ToString()
                    +"\nNombre titular: "+cuenta2.titular
                    + "\nTipo: " + cuenta2.tipo
                    + "\nSaldo: " + cuenta2.saldo
                );
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
        public Window() 
        {
            this.width = 15;
            this.height = 20;
            this.color = "rojo";
        }

        public Window(int width, int height, string color)
        {
            this.width = width;
            this.height = height;
            this.color = color;
        }

        //Re-use constructor
        public Window(int width) : this (width , 20 , "rojo") {}

        public Window(string color) : this(33) { }










        //Methods
        public void cerrar() 
        {
            this.width = 20; //Acceso desde la misma clase
            Console.WriteLine("La ventana se cerró."); 
        }
        public void maximizar() { Console.WriteLine("La ventana se maximizó."); }

    }
}
