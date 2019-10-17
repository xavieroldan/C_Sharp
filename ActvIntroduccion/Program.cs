using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActvIntroduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,output;
            double input, salary, num, add=0.0d, diff=0.0d,note=0.0d;
            int correct, failure, mult15=0, mult7=0;

            //1
            //Fer un programa en el que es demani el nom d’un empleat i el seu sou . 
            //Es vol fer un increment del 5%. De sortida  es vol el nom i el sou actual en una línia diferent.
            //Console.WriteLine("Bienvenido al incrementador de sueldo");
            //Console.WriteLine("Dime tu nombre:");
            //name = Console.ReadLine();
            //Console.WriteLine("Dime tu sueldo:");
            //input = Convert.ToDouble(Console.ReadLine());
            //salary = Math.Round((input*1.05), 2);
            //Console.WriteLine(name);
            //Set the euro symbol
            string e = Encoding.Default.GetString(new byte[] { 128 });
            Console.OutputEncoding = Encoding.Default;
            //Console.WriteLine("{0} {1}", salary, e);
            ////Console.WriteLine("Enhorabuena {0}. Tu nuevo sueldo es de {1} €",name1,salary);

            ////2
            ///*
            // Realitzar el codi necessari per donar la benvinguda i demanar el nom a la persona usuària. 
            // Un cop introduït el nom se li demana dues dades numèriques. 
            // Es farà la suma i la resta i la sortida sortirà en un missatge d’aquest tipus:
            // ‘Hola Maria, la suma  y la resta de los números introducidos es 5 y 1’
            // */
            //Console.WriteLine("\n\nBienvenido a sum resta");
            //Console.WriteLine("Dime tu nombre:");
            //name= Console.ReadLine();
            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine("Dame el número {0}:",i);
            //    num = Convert.ToDouble(Console.ReadLine());
            //    add += num;
            //    if (i > 1)
            //    {
            //        diff -= num;
            //    }
            //    else
            //    {
            //        diff = num;
            //    }      
            //}          
            //Console.WriteLine("Hola {0}, la suma  y la resta de los números introducidos es {1} y {2}",name,add,diff);

            //3
            /*
            Realitzar el codi necessari per fer el càlcul de la prova objectiva. És a dir :
            Nota=( (acerts-(errors/3))*10)/20. 
            Sortida la nota. 
             */
            Console.WriteLine("\n\nCáculo de nota objetiva");
            Console.WriteLine("Número de aciertos:");
            correct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número de fallos:");
            failure = Convert.ToInt32(Console.ReadLine());

            if (correct + failure > 20)
            {

                Console.WriteLine("Número inválido de aciertos / fallos\nIndicaste {0} y el máximo es 20.", correct + failure);
            }
            else
            {
                note = ((correct - (failure / 3)) * 10) / 20;
                Console.WriteLine("[" + Math.Round(note, 2) + "]");
                if (note >= 5)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Suspendido.");
                }
            }
            //Activitat if else
            /*
             Donat un número entrat per teclat que aparegui un missatge dient si és múltiple de 15 i/o de  7.
             */
            Console.WriteLine("\n\nMúltiplos de 15 y 7\nIntroduce un número:");
            num = Convert.ToDouble(Console.ReadLine());
            if(num % 15 == 0 && num% 7 ==0)
            {
                //multiple  15 and 7
                Console.WriteLine("Es multiplo de 15 y 7");
            }
            else if (num % 15 == 0)
            {
                //multiple 15
                Console.WriteLine("Es múltiplo de 15");
            }
            else if (num % 7 == 0)
            {
                //multiple 7
                Console.WriteLine("Es múltiplo de 7");
            }
            else
            {
                //no multiple
                Console.WriteLine("No Es múltiplo de 15 ni de 7 ");
            }

            /*
             Donat  (n)  números entrats per teclat, dir quants són múltiples de 15 i quants de 7
             */
            Console.WriteLine("\n\nIndica cuantos múltiplos quieres verificar:");
            input = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("Introduce número {0}:", i);
                num = Convert.ToDouble(Console.ReadLine());

                if (num % 15 == 0)
                {
                    //multiple 15
                    mult15++;
                }
                else if (num % 7 == 0)
                {
                    //multiple 7
                    mult7++;
                }
            }
            Console.WriteLine("Múltiplos de 15: {0}\n Múltiplos de 7: {1}", mult15, mult7);

            /*Donat un número entrat per teclat, 
             * realitzar de nou  el codi per a que informi de si és negatiu o positiu, amb un condicional ternari.*/
            Console.WriteLine("\n\nVerificar negativos/positivos.\nIntroduce un número:");
            input = Convert.ToDouble(Console.ReadLine());
            output = (input < 0) ? "negativo" : "positivo";
            Console.WriteLine(output);

            /*
              Donada una edat que aparegui  un missatge amb les tarifes d’un gimnàs.
                Nen (a partir de 6 anys i menor de 12 anys ) 15€ 
                Jove (a partir de 12 anys i menys de 30 anys 25€) 
                Adult (a partir de 30 anys i menys de 65 anys 30€)
                Jubilats (a partir de 65 anys 20€)
             */
            Console.WriteLine("\n\nTarifa Gym.\nIntroduce edad:");
            input = Convert.ToDouble(Console.ReadLine());
            if (input >= 65)
            {
                output = "Jubilats (a partir de 65 anys 20€)";
            }
            else
            {
                if (input >= 30)
                {
                    output = "Adult (a partir de 30 anys i menys de 65 anys 30€)";
                }
                else
                {
                    if (input >= 12)
                    {
                        output = "Jove (a partir de 12 anys i menys de 30 anys 25€)";
                    }
                    else
                    {
                        if (input >= 6)
                        {
                            output = "Nen (a partir de 6 anys i menor de 12 anys ) 15€";
                        }
                        else
                        {
                            output = "Entrada gratis: eres un bebé.";
                        }
                    }
                }
            }
            Console.WriteLine(output); 

            //Donat  un número que ens dóni el seu valor absolut  ( és a dir el valor positiu).
            Console.WriteLine("\n\nValor absoluto.\nIntroduce número:");
            input = Convert.ToDouble(Console.ReadLine());
            output ="El valor absoluto de ["+input+"] es [";
            output += (input >= 0) ? input.ToString() : (-input).ToString();
            output += "]";
            Console.WriteLine(output);
            

            
            //End
            Console.ReadKey();
}
}
}
