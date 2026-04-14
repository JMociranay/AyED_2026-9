using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            Console.Write("ingrese su nota de examen: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else if (4 <= nota & nota <= 6)
            {
                Console.WriteLine("A finales");
            }
            else
            {
                Console.WriteLine("Recuperatorio");

            }
        }
    }
}
