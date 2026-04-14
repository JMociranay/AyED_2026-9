using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("ingrese un numero para indica si es par o impar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("su numero es par");

            }
            else
            {
                Console.WriteLine("su numero es impar");
            }
        }
    }
}
