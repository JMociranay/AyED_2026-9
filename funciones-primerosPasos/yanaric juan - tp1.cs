using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
    static void ContarRegresivo(int numero)
        {
            Console.WriteLine("Cuenta regresiva:");

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("fin de la cuenta regresiva");
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                ContarRegresivo(numero);
            }
            else
            {
                Console.WriteLine(" debes ingresar un numero mayor que 0");
            }
        }
    }
}
