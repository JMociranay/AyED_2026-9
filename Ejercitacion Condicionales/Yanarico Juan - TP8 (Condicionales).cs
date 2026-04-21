using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.Write("ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());


            if (numero % 5 == 0)
            {
                Console.WriteLine("su numero es divisible por 5");
            }
            else
            {
                Console.WriteLine("su numero no es divisible por 5");
            }
        }
    }
}
