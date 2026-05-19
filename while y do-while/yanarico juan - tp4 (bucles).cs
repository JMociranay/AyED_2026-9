using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            Console.Write("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= 12)
            {
                resultado = numero * contador;
                Console.WriteLine(resultado);
                contador++;

            }
            
        }
    }
}
