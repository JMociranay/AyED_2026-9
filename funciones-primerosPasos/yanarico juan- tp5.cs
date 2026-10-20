using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Potencia(int baseN, int exponente)
        {
            int resultado = 1;

            for (int i = 1; i <= exponente; i++)
            {
                resultado = resultado * baseN;
            }

            return resultado;
        }

        static void Main()
        {
            Console.Write("Ingrese la base: ");
            int baseN = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente mayor o igual a 0: ");
            int exponente = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + Potencia(baseN, exponente));
        }
    }
}