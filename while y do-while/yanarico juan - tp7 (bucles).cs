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
            int contador = 1;
            double promedio, nota;
            double sumador = 0;

            while (contador <= 5)
            {
                Console.Write("ingrese la primera nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                sumador = sumador + nota;
                contador++;
            }
            promedio = sumador / 5;
            Console.WriteLine("promedio de sus notas " + promedio);




        }
    }
}
