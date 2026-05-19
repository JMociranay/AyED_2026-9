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
            int numero;
            int sumador = 0;
            do
            {
                Console.Write("ingrese un numero para sumar: ");
                numero = int.Parse(Console.ReadLine());
                sumador = sumador + numero;
            }
            while (numero != 0);
            Console.WriteLine("la suma de los numeros " + sumador);
        }
    }
}
