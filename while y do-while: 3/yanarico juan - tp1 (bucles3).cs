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
            int producto;
            double venta_total = 0;


            do
            {
                Console.Write("ingrese el precio del producto uno por uno: ");
                producto = int.Parse(Console.ReadLine());
                venta_total = producto + venta_total;

            }
            while (producto != 0);
            if (venta_total >= 15000)
            {
                double descuento = venta_total * 0.1;
                double venta_final = venta_total - descuento;
                Console.WriteLine("el descuento aplicado: " + descuento);
                Console.WriteLine("venta final:  " + venta_final);
            }
            else
            {
                Console.WriteLine("venta final: " + venta_total);
            }
         }
    }
}

