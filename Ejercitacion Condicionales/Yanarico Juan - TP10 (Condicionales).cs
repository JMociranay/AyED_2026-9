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
            double presupuesto, costo, faltante;
            Console.Write(" ingrese el presupuesto: ");
            presupuesto = Convert.ToDouble(Console.ReadLine());
            Console.Write(" ingrese el costo de los materiales: ");
            costo = Convert.ToDouble(Console.ReadLine());

            if (presupuesto < costo)
            {
                faltante = costo - presupuesto;
                Console.WriteLine("el costo es mayor al presupuesto disponible, dinero prestado que se requiere: " + faltante);

            }
            else
            {
                Console.WriteLine("el presupuesto es suficiente");
            }

        }
    }
}
