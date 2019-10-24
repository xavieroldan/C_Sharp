using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontseMod
{
    class Program
    {
        static void Main(string[] args)
        {
            string jugar = String.Empty, nombre = String.Empty;
            int intentos = 0, aleatorio = 0, numero = 0, contador = 1, intenta = 1;


            //función saludo
            jugar = greeting();

            if (jugar == "si")
            {
                //función pedir nombre
                nombre = getString("Por favor, introduce tu nombre para comenzar: ");

                //función pedir intentos
                intentos = getInt32("Hola "
                    + nombre
                    + ". Puedes escribir cuántos intentos quieres, con un máximo de 10: "
                    );

                //Función get RDM
                aleatorio = getRandom();

                while (intentos > 10)
                {
                    intentos = getInt32("El máximo son 10 intentos. Vuelve a escribir un número del 1 al 10.");
                }

                //Console.WriteLine(aleatorio);                
                numero = getInt32("Por favor, introduce un número del 1 al 100");

                while (intenta < intentos)
                {
                    if (numero == aleatorio) { break; }

                    if (numero < aleatorio && contador <= 10)
                    {
                        numero = getInt32("el número es más alto.\nVuelve a introducir un número");
                        intenta++;
                    }
                    else if (numero > aleatorio && contador <= 10)
                    {
                        numero = getInt32("el número es más bajo.\nVuelve a introducir un número");
                        intenta++;
                    }
                    contador++;
                }

                if (numero == aleatorio)
                {
                    //función texto orden acierto
                    getTextOrder(nombre, contador, aleatorio);
                }

                if (intentos == intenta && numero != aleatorio)
                {
                    Console.WriteLine("Los sentimos. Terminó el juego.");
                }
            }
            else if (jugar == "no")
            {
                Console.WriteLine("Gracias y hasta pronto!");
            }
            Console.ReadKey();
        }

        public static string greeting() {
            Console.WriteLine("BIENVENID@!!! ¿Quieres jugar? Responde si o no.");
            return Console.ReadLine();
        }

        public static string getString(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int getInt32(string text)
        {
            bool isExiting = false;
            while (!isExiting)
            {
                Console.WriteLine(text);
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato introducido no es correcto: prueba de nuevo");
                    isExiting = false;
                }
            }
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int getRandom()
        {
            Random r = new Random();
            return r.Next(1, 100);
        }

        public static void getTextOrder (string nombre, int contador,int aleatorio )
        {
            string caso = String.Empty;
            switch (contador)
                    {
                        case 1:
                            caso = "primero";
                            break;
                        case 2:
                            caso = "segundo";
                            break;
                        case 3:
                            caso = "tercer";
                            break;
                        case 4:
                            caso = "cuarto";
                            break;
                        case 5:
                            caso = "quinto";
                            break;
                        case 6:
                            caso = "sexto";
                            break;
                        case 7:
                            caso = "séptimo";
                            break;
                        case 8:
                            caso = "octavo";
                            break;
                        case 9:
                            caso = "noveno";
                            break;
                        case 10:
                            caso = "décimo";
                            break;
                    }
                Console.WriteLine("ENHORABUENA!!!" + nombre + ". Has acertado el número! " + aleatorio + " en el " + caso + " intento");
        }


    }
}
