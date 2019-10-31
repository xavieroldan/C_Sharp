using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersonaExercici
{
    class Persona
    {
        private string _Name= string.Empty;
        private int _Age= 0;
        private string _Dni;
        private string _Sex= string.Empty;
        private double _Weight = 0.0d;
        private double _Height = 0.0d;

        public Persona(string name, int age, string sex, double weight, double height)
        {
            Name = name;
            Age = age;
            Dni = GeneraDNI();
            Sex = sex;
            Weight = weight;
            Height = height;
        }

        private string Name { get => _Name; set => _Name = value; }
        private int Age { get => _Age; set => _Age = value; }
        public string Dni { get => _Dni; set => _Dni = value; }
        private string Sex { get => _Sex; set => _Sex = value; }
        public double Weight { get => _Weight; set => _Weight = value; }
        public double Height { get => _Height; set => _Height = value; }

        public int calcularIMC()
        {
            /*calcularIMC() : calculara si la persona está en su peso
                ideal (peso en kg/(altura^2 en m)), si esta fórmula
                devuelve un valor menor que 20, la función devuelve un
                -1, si devuelve un número entre 20 y 25 (incluidos),
                significa que está por debajo de su peso ideal la función
                devuelve un 0 y si devuelve un valor mayor que 25
                significa que tiene sobrepeso, la función devuelve un 1.
                Finalmente aparece en pantalla sobrepeso,etc.*/
            int output = 0;
            string message = "En peso ideal";
            double imc = (Weight / Math.Pow(Height, 2));
            if (imc < 20) 
            { 
                output = -1; 
            } 
            else if (imc >= 20 && imc <= 25) 
            {
                //under IMC
                output = 0;
                message = "Bajo el peso ideal.";
            } 
            else 
            {
                //over IMC
                output = 1;
                message = "Sobre peso.";
            } 
            Console.WriteLine(message);
            return output;
        }

        public void EsMayorDeEdad()
        {
            /*
             esMayorDeEdad() : indica si es mayor de edad.*/
            string message = "Es mayor de edad";
            if(Age<18) { message = "No es mayor de edad"; }
            Console.WriteLine(message);
        }

        public void VerInfo()
        {
            /*verInfo() : devuelve toda la información del objeto.*/
            Console.WriteLine(
            "[Name = "+ Name
            +"|Age = "+ Age
            +"|Dni = "+ Dni
            +"|Sex = "+ Sex
            +"|Weight = "+ Weight
            +"|Height = "+ Height
            +"]"
            );
        }
        public string GeneraDNI()
        {
            /*generaDNI() : genera un número aleatorio de 8 cifras,
            genera a partir de este su número su letra
            correspondiente . Este método será invocado cuando se
            construya el objeto. Puedes dividir el método para que
            te sea más fácil.*/
            Random rnd = new Random();
            string dni = string.Empty;
            string letter = "TRWAGMYFPDXBNJZSQVHLCKE";
            for (int i = 0; i < 8; i++){dni += rnd.Next(-1, 10);}
            dni += letter.ToCharArray().ElementAt(Convert.ToInt32(dni)%23);
            return dni;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public void setAge(int age)
        {
            Age = age;
        }

        public void setSex(string sex)
        {
            Sex = sex;
        }
        public void setWeight(double weight)
        {
            Weight = weight;
        }
        public void setHeight(double height)
        {
            Height = height;
        }
    }
}
