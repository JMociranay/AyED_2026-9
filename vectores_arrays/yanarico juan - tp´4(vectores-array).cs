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
            int cantidad = 0;
            Double[] precios = new double[8];
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine("ingrese el precio del producto "+ (i+1) +" : ");
                precios[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("ingrese su monto de dinero: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < precios.Length; i++)
            {
                if (precios[i] <= monto)
                {
                    cantidad++;
                }
            }
            Console.WriteLine("Puede comprar " + cantidad + " productos distintos.");
        }
    }
}
