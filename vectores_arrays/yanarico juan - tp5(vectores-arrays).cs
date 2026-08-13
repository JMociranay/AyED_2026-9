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
            int contador = 0;
            int[] rifa_vendida = new int[15];
            for (int i = 0; i < rifa_vendida.Length; i++)
            {
                Console.Write("Ingrese el número vendido " + (i + 1) + ": ");
                rifa_vendida[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("que numero de rifa desea comprar: ");
            int num_rifa = int.Parse(Console.ReadLine());
            for (int i = 0; i < rifa_vendida.Length; i++)
            {
                if (num_rifa == rifa_vendida[i])
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                Console.WriteLine("el numero de rifa fue vendida");
            }
            else
            {
                Console.WriteLine("el numero de rifa aun esta disponible");

            }
        }
    }
}
