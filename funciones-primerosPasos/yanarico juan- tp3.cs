using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int sumarhasta(int numero)
        {
            int sumador = 0;

            for (int i = 1; i <= numero; i++)
            {
                sumador += i;
            }
            return sumador;

        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                int resultado = sumarhasta(numero);
                Console.WriteLine("la sumatoria del 1 hasta tu numero: " + resultado);
            }
            else
            {
                Console.WriteLine(" debes ingresar un numero mayor que 0");
            }
        }
    }
}