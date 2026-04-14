using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidad;
            Console.Write("ingrese la velocidad del vehiculo: ");
            velocidad = Convert.ToDouble(Console.ReadLine());
            if (velocidad > 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else
            {
                Console.WriteLine("Conducción segura");
            }
        }

    }
}
