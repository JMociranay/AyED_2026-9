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
            double compras_droides, descuento, total, precio_final;
            Console.WriteLine("ingrese la cantidad de droides que comprara: ");
            compras_droides = Convert.ToDouble(Console.ReadLine());
            total = compras_droides * 2000;
            descuento = total * 0.2;
            precio_final = total - descuento;
            if (compras_droides >= 3)
            {
                Console.WriteLine("el total del precio " + total);
                Console.WriteLine("el descuento aplicado " + descuento);
                Console.WriteLine("el precio final " + precio_final);
            }
            else
            {
                Console.WriteLine("el total del precio " + total);


            }
        }
    }
}
