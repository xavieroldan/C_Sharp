using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Barco acuatico1 = new Barco("barco1", "acuatico1");
            //acuatico1.Transportar();
            //acuatico1.Navegar();
            //acuatico1.PrenderMotor();

            Vehiculo acuatico2 = new Velero("Velero1", "acuatico2");
            //acuatico2.Transportar();
            Velero acuatico3 = new Velero("Velero2", "acuatico3");


            Avion aereo1 = new Avion("Aereo1", "avion1");
            Helicoptero aereo2 = new Helicoptero("Aereo2", "heli2");

            Vehiculo[] listaVehiculo = { acuatico1, acuatico2, acuatico3, aereo1, aereo2 };
            //Acuatico[] listaAcuaticos = { acuatico1, acuatico2, acuatico3 }; -> error
            Acuatico[] listaAcuaticos = { acuatico1, acuatico3 };
            Aereo[] listaAereo = { aereo1, aereo2 };

            foreach (var item in listaVehiculo)
            {
                Console.WriteLine("Name->" + item.GetNameVehicle());
                ShowMethods(item.GetType());                
                Console.WriteLine("\n");
            }

            Console.WriteLine("vehiculos {0}, acuaticos {1}, aereos {2}, barcos {3}, veleros {4}, aviones {5}, helicópteros {6}"
                ,Vehiculo.NumVehiculos(), Acuatico.NumVehiculos(), Aereo.NumVehiculos(), Barco.NumVehiculos(), Velero.NumVehiculos(), Avion.NumVehiculos(), Helicoptero.NumVehiculos());

            //Vehiculo vh1 = listaAereo[1];

            //Console.WriteLine(vh1.GetNameVehicle() ); 

            //Console.WriteLine("vehiculos "+Vehiculo.NumVehiculos());




            Console.ReadKey();
        }

        static void ShowMethods(Type type)
        {
            foreach (var method in type.GetMethods())
            {
                var parameters = method.GetParameters();
                var parameterDescriptions = string.Join
                    (", ", method.GetParameters()
                                 .Select(x => x.ParameterType + " " + x.Name)
                                 .ToArray());

                Console.WriteLine("{0} {1} ({2})",
                                  method.ReturnType,
                                  method.Name,
                                  parameterDescriptions);
            }
        }
    }
}
