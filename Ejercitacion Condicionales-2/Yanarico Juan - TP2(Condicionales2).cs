using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, IMC;
            Console.Write("ingrese su altura en M: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese su peso en KG: ");
            peso = Convert.ToDouble(Console.ReadLine());

            IMC = peso / (altura * altura);
            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso: "+ IMC);


            }
            else
            {
                Console.WriteLine("Rango Normal: "+ IMC);
            }
        }
    }
}
