using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do
            {
                Console.Write("ingrese un valor de nota del 1-10 (entero): ");
                nota = int.Parse(Console.ReadLine());
                if ((nota < 1) || (nota > 10))
                {
                    Console.WriteLine("nota no valida ,ingrese de nuevo: ");
                }
            }
            while ((nota < 1) || (nota > 10));
            Console.WriteLine("la nota correcta es " + nota);

        }
    }
}
