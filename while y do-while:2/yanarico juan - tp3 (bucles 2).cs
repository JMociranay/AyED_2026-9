using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = true;
            double venta;
            double Recaudado = 0;
            double venta_alta = 0;
            int cantidadVentas = 0;
            String continuar;

            do
            {
                Console.Write("Ingrese el monto de la venta: ");
                venta = Convert.ToDouble(Console.ReadLine());

                Recaudado += venta;
                cantidadVentas++;

                if (venta > venta_alta)
                {
                    venta_alta = venta;
                }

                Console.Write("¿Desea ingresar otra venta? (S/N): ");
                continuar = Console.ReadLine();
                if ((continuar == "N") || ( continuar == "S") || (continuar == "n") || (continuar == "s"))
                {
                    if ((continuar == "N") || (continuar == "n"))
                    {
                        finalizar = false;

                    }

                }
                else
                {
                    Console.WriteLine("opcion no valida");
                }

            } while (finalizar == true);
            Console.WriteLine("Total recaudado: $" + Recaudado);
            Console.WriteLine("Cantidad de ventas: " + cantidadVentas);
            Console.WriteLine("Venta más alta: $" + venta_alta);
        }
    }
}
