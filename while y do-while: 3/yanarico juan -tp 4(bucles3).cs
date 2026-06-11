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
            int numero_menor= 99999999;
            int numero = 1;
            while (numero >= 0)
            {
                Console.Write("ingrese un numero para iniciar la lista: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero < numero_menor)
                    {
                        numero_menor = numero;
                    }
                }
            }
            Console.WriteLine("numero menor de la lista: " + numero_menor);
        }
    }
}
