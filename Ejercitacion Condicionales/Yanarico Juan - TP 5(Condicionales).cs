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
            double monto, monto_final, descuento;
            Console.Write("ingrese el monto a pagar: ");
            monto = Convert.ToDouble(Console.ReadLine());
            if (monto >= 5000)
            {
                descuento = monto * 0.15;
                monto_final = monto - descuento;
                Console.WriteLine("descuento aplicado a su monto, monto final: " + monto_final);

            }
            else
            {
                Console.WriteLine("monto a pagar: " + monto);
            }
        }
    }
}
