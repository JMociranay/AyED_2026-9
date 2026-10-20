using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Factorial(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        static void Main()
        {
            Console.Write("Ingrese un numero entero mayor o igual a 0: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("El factorial es: " + Factorial(n));
        }
    }
}