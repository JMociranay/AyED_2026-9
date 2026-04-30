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
            double horas, pago, precio, precio_final, vuelto;
            precio = 0;
            Console.Write("ingrese la cantidad de horas que dejo su auto estacionado: ");
            horas = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese la cantidad de plata con el cual pagara: ");
            pago = Convert.ToDouble(Console.ReadLine());

            if ( horas > 1)
            {
                precio = (horas - 1) * 1600;
                precio_final = precio + 4000;
                if (pago >= precio_final)
                {
                    vuelto = pago - precio_final;
                    Console.WriteLine("vuelto "+ vuelto);
                }
                else
                {
                    Console.WriteLine(" le falta " + (precio_final - pago) + " de dinero");
                }

            }
            else if (horas == 1)
            {
                precio_final = precio + 4000;
                if (pago >= precio_final)
                {
                    vuelto = pago - precio_final;
                    Console.WriteLine("vuelto "+ vuelto);
                }
                else
                {
                    Console.WriteLine(" le falta " + (precio_final - pago) + " de dinero");
                }
            }
        }
    }
}
