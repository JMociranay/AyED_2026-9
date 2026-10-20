using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void ContarHasta(int numero)
        {
            Console.WriteLine("conteo iniciado:");

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("fin del conteo");
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                ContarHasta(numero);
            }
            else
            {
                Console.WriteLine(" debes ingresar un numero mayor que 0");
            }
        }
    }
}
