using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero_inicio = 0;

            Console.Write("Inicio (numero entero): ");
            numero_inicio = Convert.ToInt32(Console.ReadLine());

            int numero_final = 0;

            do
            {
                Console.Write("Fin (numero entero): ");
                numero_final = Convert.ToInt32(Console.ReadLine());
                if (numero_final <= numero_inicio)
                {
                    Console.WriteLine("no ingreso un numero mayor a " + numero_inicio);
                }
            } while (numero_final <= numero_inicio);

            numeros_comprendidos(numero_inicio, numero_final);

            Console.WriteLine("\nPares: " + cant_pares(numero_inicio, numero_final));
            Console.WriteLine("Impares: " + cant_impares(numero_inicio, numero_final));
            Console.WriteLine("Suma de todos los valores: " + suma_valores(numero_inicio, numero_final));

        }

        static int cant_pares(int inicio, int fin)
        {
            int pares = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    pares++;
                }
            }

            return pares;
        }

        static int cant_impares(int inicio, int fin)
        {
            int impares = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 != 0)
                {
                    impares++;
                }
            }

            return impares;
        }

        static void numeros_comprendidos(int inicio, int fin)
        {
            Console.WriteLine("\nNumeros del " + inicio + " al " + fin);
            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int suma_valores(int inicio, int fin)
        {
            int acumulador = 0;

            for (int i = inicio; i <= fin; i++)
            {
                acumulador += i;
            }

            return acumulador;
        }

    }
}