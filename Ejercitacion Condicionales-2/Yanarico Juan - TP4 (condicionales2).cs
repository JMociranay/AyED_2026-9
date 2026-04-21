using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, antiguedad, sueldo_nuevo, aumento;
            Console.Write("ingrese su sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese la antiguedad: ");
            antiguedad = Convert.ToDouble(Console.ReadLine());

            if (antiguedad >= 10)
            {
                aumento = sueldo * 0.2;
                sueldo_nuevo = sueldo + aumento;
                Console.WriteLine("su sueldo modificado: " + sueldo_nuevo);

                
            }
            else
            {
                aumento = sueldo * 0.05;
                sueldo_nuevo = sueldo + aumento;
                Console.WriteLine("su sueldo modificado: " + sueldo_nuevo);


            }
        }
    }
}
