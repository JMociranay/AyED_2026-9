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
            Console.Write("¿Cuántos números desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese un número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Mayor: " + Mayor(numeros));
            Console.WriteLine("Menor: " + Menor(numeros));
            Console.WriteLine("Promedio: " + Promedio(numeros));
            Console.WriteLine("Cantidad de pares: " + CantidadPares(numeros));
            Console.WriteLine("Cantidad de impares: " + CantidadImpares(numeros));
        }
        static int Mayor(int[] numeros)
        {
            int mayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            return mayor;
        }

        static int Menor(int[] numeros)
        {
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            return menor;
        }

        static double Promedio(int[] numeros)
        {
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            return (double)suma / numeros.Length;
        }

        static int CantidadPares(int[] numeros)
        {
            int cantidad = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        static int CantidadImpares(int[] numeros)
        {
            int cantidad = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }
    }
}
