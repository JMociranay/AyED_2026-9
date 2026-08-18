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
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;
            int[] clientes = new int[25];
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.Write("ingrese su calficacion de la atencion de un 1-5: ");
                clientes[i] = int.Parse(Console.ReadLine());
                if ((clientes[i] < 0) || (clientes[i] > 5))
                {
                    Console.WriteLine("opcion no valida");
                }
                else if (clientes[i] == 1)
                {
                    uno++;
                }
                else if (clientes[i] == 2)
                {
                    dos++;
                }
                else if (clientes[i] == 3)
                {
                    tres++;
                }
                else if (clientes[i] == 4)
                {
                    cuatro++;
                }
                else if (clientes[i] == 5)
                {
                    cinco++;
                }
            }
            Console.WriteLine(uno + " clientes votaron 1");
            Console.WriteLine(dos + " clientes votaron 2");
            Console.WriteLine(tres + " clientesvotaron 3");
            Console.WriteLine(cuatro + " clientesvotaron 4");
            Console.WriteLine(cinco + " clientes votaron 5");
        }
    }
}
