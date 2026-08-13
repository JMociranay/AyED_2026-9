using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_sucursal_1 = 0;
            int total_sucursal_2 = 0;
            int dia = 0;
            int[] sucursal_1 = new int[5];
            int[] sucursal_2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                dia++;
                Console.WriteLine("ingrese la cantidad de ventas del dia " + dia + " de la sucursal l: ");
                sucursal_1[i] = int.Parse(Console.ReadLine());
                total_sucursal_1 += sucursal_1[i];
                Console.WriteLine("ingrese la cantidad de ventas del dia " + dia + " de la sucursl 2: ");
                sucursal_2[i] = int.Parse(Console.ReadLine());
                total_sucursal_2 += sucursal_2[i];
                if (sucursal_1[i] > sucursal_2[i])
                {
                    Console.WriteLine("la sucursal 1 tuvo mayor ventas en este dia");
                }
                else if (sucursal_1[i] == sucursal_2[i])
                {
                    Console.WriteLine("las sucursales tuvieron las misma ventas en este dia");
                }
                else
                {
                    Console.WriteLine("la sucursal 2 tuvo mayor ventas en este dia");
                    Console.WriteLine("");

                }
            }
            if (total_sucursal_1 > total_sucursal_2)
            {
                Console.WriteLine("la sucursal 1 tuvo mayor ventas en la semana");
            }
            else if (total_sucursal_1 == total_sucursal_2)
            {
                Console.WriteLine("las sucursales tuvieron las misma ventas en la semana");
            }
            else
            {
                Console.WriteLine("la sucursal 2 tuvo mayor ventas en la semana");
            }
        }

    }
}
