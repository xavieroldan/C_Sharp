using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivitatGrupal1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fer un programa en el qual es demana si es vol o no jugar.
             En el cas de voler jugar:
            Es demana el nom i es demana quants intents es volen.
            Com a molt es deixa jugar 10 intents, s’ha de controlar que no posi més.
            A nivel intern es genera un número aleatori.
            Es van demanant números fins que no encerti o fins que es passi dels intents introduïts.
            Si s’encerta abans del número màxim d’intents es felicita i es fa una sortida del tipus:
            “Felicitats Laura has encertat al tercer intent “
            Posar : tercer, quart,etc…
            Sinó “Laura t’has passat d’intents…teníem cinc intents…”
            En el cas de no voler jugar apareix una sortida del tipus: “Laura..Un altre dia será…”
             */

            string answer = string.Empty, playerName = string.Empty;
            int attempts, secretNum, playerNum, contAttempts;
            string[] textNum =
             {
                "cero",
                "un",
                "dos",
                "tres",
                "cuatro",
                "cinco",
                "seis",
                "siete",
                "ocho",
                "nueve",
                "diez"
                };
            string[] textOrder =
            {
                "cero",
                "primer",
                "segundo",
                "tercero",
                "cuarto",
                "quinto",
                "sexto",
                "séptimo",
                "octavo",
                "noveno",
                "décimo"
            };
            Random rnd = new Random();
            bool isWinner= false;

        getName:   
            Console.WriteLine("¿Cuál es tu nombre?");
            playerName = Console.ReadLine();
            if(playerName.Length<1)
            {
                Console.WriteLine("{0} no es un nombre correcto...");
                goto getName;
            }

        startMenu:            
            Console.WriteLine("¿Quieres jugar {0}?(S/N)",playerName);
            answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "s":
                    goto play;
                case "n":
                    goto end;
                default:
                    Console.Clear();
                    goto startMenu;
            }

            //Start play
        play:
            //Get the attempts
            Console.WriteLine("¿Cuantos intentos quieres?(1-10)");
            try
            {
                attempts = Convert.ToInt32(Console.ReadLine());
                if (attempts <= 0||attempts >10)
                {                   
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Indica un número entero mayor que cero por favor.");
                goto play;
            }
            //Try to get the result
            secretNum = rnd.Next(1, 10);
            contAttempts = attempts;
            Console.WriteLine("Tienes {0} intentos para adivinar el número entre el 1 y el 10",textNum[attempts]);

            for (int i = 1; i <= attempts; i++)
            {
                Console.WriteLine("¿Cuál es el número?");
                try
                {
                    playerNum = Convert.ToInt32(Console.ReadLine());
                    if(playerNum==secretNum)
                    {
                        isWinner = true;
                        contAttempts = i;
                        break;
                    }
                    else if(playerNum>10||playerNum<=0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        contAttempts--;
                        Console.WriteLine(
                            "{0}: no has acertado. Tienes {1} intentos disponibles.", playerName, textNum[contAttempts]);
                    }
                }
                catch (Exception)
                {
                    contAttempts--;
                    Console.WriteLine(
                        "No indicaste una respuesta correcta. Tienes {1} intentos disponibles.", textNum[contAttempts]);                    
                }                
            }
            if (isWinner==true)
            {
                Console.WriteLine(
                    "Felicidades {0}!!! Has acertado al {1} intento.",playerName,textOrder[contAttempts]);
            }
            else
            {
                Console.WriteLine(
                    "{0}: te has pasado de intentos...teníamos {1} intentos...", playerName,textNum[attempts]);
            }

            //Exit menu
        exitMenu:
            Console.WriteLine("¿Jugar de nuevo?(S/N)");
            answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "s":
                    goto play;
                case "n":
                    goto end;
                default:                    
                    goto exitMenu;
            }

            //End game
        end:
            Console.WriteLine("{0}..Otro dia será...", playerName);
            Console.ReadKey();      
            }
        }
    }

