using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo, retiro;
            Console.Write("ingrese su saldo actual: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese el monto a retirar: ");
            retiro = Convert.ToDouble(Console.ReadLine());

            if(retiro < saldo)
            {
                if ( retiro % 1000 == 0)
                {
                    Console.WriteLine("se retiro el dinero con exito");
                }
                else
                {
                    Console.WriteLine("solo billetes de 1000");
                }
            }
            else
            {
                Console.WriteLine("fondos insuficientes");

            }

        }
    }
}
