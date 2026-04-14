using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcion;
            Console.WriteLine("test de personalidad");
            Console.WriteLine("1. Lo devuelves al templo");
            Console.WriteLine("2. Lo vendes por créditos");
            Console.WriteLine("3. Lo usas para construir un arma roja");
            Console.Write("Encuentras un cristal Kyber perdido. ¿Qué haces ?: ");
            opcion = Convert.ToDouble(Console.ReadLine());
            if (0 < opcion & opcion <= 3)
            {
                if (opcion == 1)
                {
                    Console.WriteLine("El camino del Jedi sigue");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("Un cazarrecompensas eres");
                }
                if (opcion == 3)
                {
                    Console.WriteLine("El Lado Oscuro se apodera de ti");
                }            
            }
            else
            {
                Console.WriteLine("Error en la Fuerza: opción inválida");

            }
        }
    }
}
