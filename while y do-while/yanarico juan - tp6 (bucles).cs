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
            int numero;
            int contador = 1;
            Console.Write("ingrese un numero limite: ");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
        }
    }
}
