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
            double total = 1;
            int[] precios = new int[10];
            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write("ingrese el precio del producto " + (i + 1) + " : ");
                precios[i] = int.Parse(Console.ReadLine());
                total += precios[i];
            }
            total -= 1;
            Console.WriteLine("ingrese el numero de producto que desea descontar del 1-10: ");
            int opcion = int.Parse(Console.ReadLine());
            opcion -= 1;
            int Producto = precios[opcion];
            Console.WriteLine("el precio del producto "+ (opcion +1) + " es "+ Producto);
            Console.WriteLine("el total era de " + total + " ,ahora el nuevo total es de " + (total - Producto));
        }
    }
}
