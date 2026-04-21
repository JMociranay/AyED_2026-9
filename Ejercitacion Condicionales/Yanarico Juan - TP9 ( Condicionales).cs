using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hermano_1, hermano_2, diferencia;
            Console.Write("ingrese la edad del primer hermano: ");
            hermano_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrse la edad del segundo hermano: ");
            hermano_2 = Convert.ToInt32(Console.ReadLine());

            if (hermano_1 > hermano_2)
            {
                diferencia = hermano_1 - hermano_2;
                Console.WriteLine("el primer hermano es mayor, y la diferencia de edad es de " + diferencia);

            }
            else if (hermano_2 == hermano_1)
            {
                Console.WriteLine(" tienen la misma edad");
            }
            else
            {
                diferencia = hermano_2 - hermano_1;
                Console.WriteLine("el segundo hermano es mayor, y la diferencia de edad es de " + diferencia);
            }

        }
    }
}
