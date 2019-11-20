using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    class Electrodomestico
    {
        //precio base, color, consumo energético (letras entre A y F) y peso.
        private double _Price = 100.0d;
        private Color _Color = Color.blanco;
        private EnergyClass _EnergyClass = EnergyClass.F;
        private double _Weight = 5.0d;

        public Electrodomestico(double price, Color color, EnergyClass energyClass, double weight)
        {
            Price = price;
            Color = color;
            EnergyClass = energyClass;
            Weight = weight;
        }

        internal double Price { get => _Price; set => _Price = value; }
        internal Color Color { get => _Color; set => _Color = value; }
        internal EnergyClass EnergyClass { get => _EnergyClass; set => _EnergyClass = value; }
        private double Weight { get => _Weight; set => _Weight = value; }
        

        public double GetPrice()  { return Price; }
        public Color GetColor() { return Color; }
        public EnergyClass GetEnergyClass() { return EnergyClass; }
        public double GetWeight() {return Weight;  }

        public virtual void PrecioFinal()
        {
            double[] energyInc = { 100, 80, 60, 50, 30, 10 };
            double[,] weightInc = {{ 19, 50 }, { 49, 80}, { 79, 100 }};//TODO: keep with >= 80 weight
            double priceInc = Price, incTemp = 10; //starts at the min cost


            //Energy increment
            for (int i = 0; i < energyInc.Length; i++)
            {
                if((int)EnergyClass == i)            
                 { 
                    priceInc += energyInc[i];
                    break;
                }
            }

            //Weight increment
            for (int i = 0; i < weightInc.Length; i++)
            {                
                if (Weight > weightInc[i,0])
                {
                    incTemp = weightInc[i, 1];
                }
                else { break; }
            }    
            Price = priceInc += incTemp;
        }
    }
}
