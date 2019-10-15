using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int num1;
            int num2;
            int output;

            //Wellcome
            Console.WriteLine("Set your name");
            nombre = Console.ReadLine();
            Console.WriteLine("Hello " + nombre);

            //Add
            Console.WriteLine("Get me the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Get me the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            output = num1 + num2;
            Console.WriteLine(num1+"+"+num2+"="+output);

            //End
            Console.ReadKey();
        }
    }
}
