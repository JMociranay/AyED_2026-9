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
            Console.Write("ingrese un numero para la cuentra regresiva: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                Console.WriteLine("numero " + numero);
                numero--;
            }
        }
    }
}
