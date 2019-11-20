using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico MyElect = new Electrodomestico(100, Color.azul, EnergyClass.C, 50);
            MyElect.PrecioFinal();
            Console.WriteLine("Price->"+MyElect.GetPrice());
            Console.WriteLine("Color->" + MyElect.GetColor());
            Console.WriteLine("Energy->" + MyElect.GetEnergyClass());
            Console.WriteLine("Weight->" + MyElect.GetWeight());

            Lavadora MyLavadora = new Lavadora(40, 100, Color.azul, EnergyClass.C, 50);
            MyLavadora.PrecioFinal();
            Console.WriteLine("\nPrice->" + MyLavadora.GetPrice());
            Console.WriteLine("Color->" + MyLavadora.GetColor());
            Console.WriteLine("Energy->" + MyLavadora.GetEnergyClass());
            Console.WriteLine("Weight->" + MyLavadora.GetWeight());
            Console.WriteLine("Charge->" + MyLavadora.GetCarga());

            Television MyTv = new Television(42, true, 100, Color.azul, EnergyClass.C, 50);
            MyTv.PrecioFinal();
            Console.WriteLine("\nPrice->" + MyTv.GetPrice());
            Console.WriteLine("Color->" + MyTv.GetColor());
            Console.WriteLine("Energy->" + MyTv.GetEnergyClass());
            Console.WriteLine("Weight->" + MyTv.GetWeight());
            Console.WriteLine("Resolution->" + MyTv.GetResolution());
            Console.WriteLine("TDT->" + MyTv.GetTdt());

            

            Console.ReadKey();

        }
    }
}
