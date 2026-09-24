using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[15];

            Console.WriteLine("Ingrese 15 numeros enteros\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero n°" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int cant_positivos = Cant_positivos(numeros);
            int cant_negativos = Cant_negativos(numeros);
            int igualesACero = IgualesCero(numeros);

            Console.WriteLine("\nPositivos: " + cant_positivos);
            Console.WriteLine("Negativos: " + cant_negativos);
            Console.WriteLine("Iguales a cero: " + igualesACero);
            Console.WriteLine("Promedio positivos: " + promedio_pos(numeros, cant_positivos));
            Console.WriteLine("Promedio negativos: " + promedio_neg(numeros, cant_negativos));

        }

        static int Cant_negativos(int[] numeros)
        {
            int negativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    negativos++;
                }
            }

            return negativos;
        }

        static double promedio_neg(int[] numeros, int cantNegativos)
        {
            double acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    acumulador += numeros[i];
                }
            }

            double promedio = acumulador / cantNegativos;

            return promedio;
        }

        static int Cant_positivos(int[] numeros)
        {
            int positivos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    positivos++;
                }
            }

            return positivos;
        }

        static double promedio_pos(int[] numeros, int cantPositivos)
        {
            double acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    acumulador += numeros[i];
                }
            }

            double promedio = acumulador / cantPositivos;

            return promedio;
        }

        static int IgualesCero(int[] numeros)
        {
            int igualesCero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    igualesCero++;
                }
            }

            return igualesCero;
        }

    }
}