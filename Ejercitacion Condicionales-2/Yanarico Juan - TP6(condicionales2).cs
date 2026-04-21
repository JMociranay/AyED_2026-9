using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, promedio;
            Console.Write("ingrse su promedio: ");
            promedio = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese la distancia de su casa a la facultad: ");
            distancia = Convert.ToDouble(Console.ReadLine());

            if ((distancia >= 50) || (promedio >= 8))
            {
                Console.WriteLine("Beca Concedida");
            }
            else
            {
                Console.WriteLine("beca no concedida");
            }

        }
    }
}
