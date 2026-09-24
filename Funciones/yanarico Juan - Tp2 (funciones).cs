using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero_ingresado = 0;
            do
            {
                Console.Write("Ingrese un número entero positivo: ");
                numero_ingresado = Convert.ToInt32(Console.ReadLine());

            } while (numero_ingresado < 0);

            if (EsPerfecto(numero_ingresado))
            {
                Console.WriteLine("El " + numero_ingresado + " es un numero perfecto");
            }
            else
            {
                Console.WriteLine("El " + numero_ingresado + " no es un numero perfecto");
            }

        }

        static bool EsPerfecto(int numero)
        {
            bool esPerfecto = false;
            int sumador = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumador += i;
                }
            }

            if (numero == sumador)
            {
                esPerfecto = true;
            }

            return esPerfecto;
        }

    }
}