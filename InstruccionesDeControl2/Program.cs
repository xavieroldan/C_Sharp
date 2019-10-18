using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstruccionesDeControl2
{
    class Program
    {
        static void Main(string[] args)
        {   //1.	Programa: Realitzar la multiplicació de cinc números entrats per teclat.
            int num = 0;
            double result = 1;

            Console.WriteLine("Multiplicar 5 números.");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Introduce el número {0}:", i);
                num = Convert.ToInt32(Console.ReadLine());
                result *= num;
            }
            Console.WriteLine("El resultado es {0}", result);

            //2.	Escriure  un programa que llegeixi 10 notes d’alumnes  
            //i ens informi de quants tenen una nota major o igual a 7 i quants  tenen una nota menor a 7.
            int up7 = 0, down7 = 0;
            double note, refer = 7.0d;

            Console.WriteLine("\nNotas >= 7 y < 7.");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Introduce la nota (decimales separados por coma) {0}:", i);
                note = Convert.ToDouble(Console.ReadLine());
                if (note >= refer)
                {
                    up7++;
                    Console.WriteLine(">=7");
                }
                else
                {
                    down7++;
                    Console.WriteLine("<7");
                }
            }
            Console.WriteLine("Notas >= de 7: {0}\n Notas < de 7: {1} ", up7, down7);

            //3.	Escriure  un programa que llegeixi n notes d’alumnes  
            //i ens informi de quants insuficients, suficients, ‘bienes’
            //  , notables i excel•lents n’hi han.
            int cont, numNote, insf = 0, suf = 0, bien = 0, not = 0, excl = 0;
            double note2 = 0.0d;

            Console.WriteLine("\nInforme insufi, sufi, bien, notable, excel.lent");
            Console.WriteLine("¿Cuantas notas quieres evaluar?(Decimales con coma)");
            cont = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cont; i++)
            {
                Console.WriteLine("Introduce la nota {0}:", i);
                note2 = Convert.ToDouble(Console.ReadLine());
                if (note2 < 5) { insf++; }
                else if (note2 >= 5 && note2 < 6) { suf++; }
                else if (note2 >= 6 && note2 < 8) { bien++; }
                else if (note2 >= 8 && note2 < 9) { not++; }
                else if (note2 >= 9) { excl++; }
            }
            Console.WriteLine("Insuficientes: {0}" +
                "\nSuficientes: {1}" +
                "\nBien: {2}" +
                "\nNotable: {3}" +
                "\nExcelente {4} ", insf, suf, bien, not, excl);

            //4.	Es demana entrar la llista de les 10 persones inscrites a un curs
            //, per després obtindre el llistat dels seus noms entre espais.
            string classList = string.Empty;

            Console.WriteLine("\nListado de alumnos");

            for (int i = 1; i <= 10; i++)
            {
                classList += Console.ReadLine() + " ";
            }
            Console.WriteLine("\n" + classList);

            //5.	Programa que mostri els números parells que hi hagi  de l’1 al 100.

            int pairNum;

            Console.WriteLine("\nLista de pares del 1 al 100");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }
            }

           // 6.Programa que imprimeixi  la suma de tots els números senars
           //que van de l’1 al 50 i em digui quants n’hi han.

            int senar, sumSenar = 0; ;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumSenar++;
                }
            }

            Console.WriteLine("Hay {0} números impares del 1 al 50", sumSenar);

            //7.	Programa que demani un número entre 1 i 10 i  
            //digui si és parell o no. Assegurar que és un numero entre 1 i 10.

            int num3;
            string output = string.Empty;

            Console.WriteLine("\nNúmero entre el 1 y el 10.");
            Console.WriteLine("Dame un número entero entre 1 y 10:");
            num3 = Convert.ToInt32(Console.ReadLine());

            output = (num3 > 0 && num3 <= 10) ? output += "El número es " : output += "Número fuera de rango";

            if (output == "El número es ")
            {
                output = (num3 % 2 == 0) ? output += "par" : "impar";
            }
            Console.WriteLine(output);

            //8.	Un cop entrat un usuari en concret (els nostre nom per exemple…), 
            /*demanar una clau numèrica fins que s’entri la correcta.
                Limitar el número d’intents. 
                Tenir en compte les diferents sortides possibles.*/

            string user = string.Empty, psw = string.Empty, text = string.Empty;
            int atempts = 3;
            bool isExiting = false;

            Console.WriteLine("\nUsuario y contraseña 3 intentos.");
            Console.WriteLine("Dame un usuario:");
            user = Console.ReadLine().ToLower();
            if (user != "xavi")
            {
                //Error user
                Console.WriteLine("El usuario {0} no es correcto.", user);
            }
            else
            {
                do
                {
                    Console.WriteLine("\nDame la contraseña:");
                    psw = Console.ReadLine().ToLower();
                    if (psw != "1234")
                    {
                        //Error psw
                        atempts--;
                        Console.WriteLine("Te quedan {0} intentos de login ", atempts);
                        if (atempts == 0)
                        {
                            text = "Cuenta bloqueada";
                            isExiting = true;
                        }
                    }
                    else
                    {
                        text = "Estás logeado";
                        isExiting = true;
                    }
                } while (!isExiting);

                Console.WriteLine(text);
            }

            //9.	Fer un programa que entrat una cadena de text em retorni la cadena de text a l’inversa.
            // Sense el mètode propi de la classe String que ho fa directament.

            string inputText = string.Empty, outputText = string.Empty;
            char a,  b;

            Console.WriteLine("\nGirando la frase.");
            Console.WriteLine("Dame un texto a girar:");
            inputText = Console.ReadLine().ToLower();

            foreach (var item in inputText)
            {
                outputText = item + outputText;
            }
            Console.WriteLine("["+outputText+"]");

            //End
            Console.ReadKey();
        }
    }
}
