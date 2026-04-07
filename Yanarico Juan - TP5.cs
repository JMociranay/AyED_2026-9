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
            double minutos_estacionado, horas, minutos, iva_costo, costo_horas, costo_minutos, costo, monto_final;
            Console.Write("coloque la cantidad de minutos que su auto estuvo en el estacionamiento: ");
            minutos_estacionado = Convert.ToDouble(Console.ReadLine());
            //
            horas = minutos_estacionado / 60;
            Console.WriteLine("horas:" + horas);
            minutos = minutos_estacionado % 60;
            Console.WriteLine("minutos "+ minutos);
            //
            costo_horas = horas * 6000;
            costo_minutos = minutos * 150;
            costo = costo_horas + costo_minutos;
            //
            iva_costo = costo * 0.21;
            monto_final = costo + iva_costo;
            //
            Console.WriteLine("minutos estacionado: " + minutos_estacionado);
            Console.WriteLine("costo total: " + costo);
            Console.WriteLine("costo de iva: "+ iva_costo);
            Console.WriteLine("monto final: "+ monto_final);


        }
    }
}
