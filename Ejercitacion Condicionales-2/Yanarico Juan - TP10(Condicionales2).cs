using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int facturas, docenas, precio_docena, dinero_recaudado, sobrante;
            Console.Write("ingrese la cantidad de facturas producidas: ");
            facturas = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese la cantidad de docenas vendidas: ");
            docenas = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el precio de la docena: ");
            precio_docena = Convert.ToInt32(Console.ReadLine());


            if (facturas >= (docenas * 12))
            {
                dinero_recaudado = docenas * precio_docena;
                sobrante = facturas - (docenas * 12);
                Console.WriteLine("dinero recaudado " + dinero_recaudado + " sobran " + sobrante + " facturas");
                if (sobrante > 6)
                {
                    Console.WriteLine("alerta, exceso de produccion");
                }
                else
                {
                    Console.WriteLine("produccion eficiente");
                }


            }
            else 
            {
                Console.WriteLine("error, las facturas no sobrepasan de las docenas");
            }

        }
    }
}
