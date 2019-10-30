using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersonaExercici
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ahora, crea una clase principal que haga lo siguiente:
            ▪ Pide por teclado el nombre, la edad, sexo, peso y altura.
            ▪ Crea 3 objetos de la clase anterior.
            ▪ Para cada objeto, deberá comprobar si está en su peso
                ideal, tiene sobrepeso o por debajo de su peso ideal con un
                mensaje.
            ▪ Indicar también para cada objeto si es mayor de edad.
            ▪ Por último, mostrar la información de cada objeto.*/

            string name = string.Empty, sex = string.Empty;
            int age = 0, n = 2;
            double weight = 0.0d, height = 0.0d;
            Persona[] listPerson = new Persona[3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nombre:");
                name = Console.ReadLine();
                Console.WriteLine("Edad:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sexo:");
                sex = Console.ReadLine();
                Console.WriteLine("Peso:");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Altura:");
                height = Convert.ToDouble(Console.ReadLine());

                Persona myPerson = new Persona(name, age, sex, weight, height);
                listPerson[i] = myPerson;
            }

            for (int i = 0; i < n; i++)
            {
                listPerson[i].VerInfo();
                listPerson[i].calcularIMC();
                listPerson[i].EsMayorDeEdad();                
            }
            Console.ReadKey();
        }
    }
}
