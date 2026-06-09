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
            int contador_edades = 0;
            int sumador_edades = 0;
            int menores = 0;
            int mayores = 0;
            int numero = -1;
            do
            {
                Console.Write("ingrese una edad: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 18)
                {
                    mayores++;
                    sumador_edades = sumador_edades + numero;
                    contador_edades++;
                }
                else if (numero > 0 )
                {
                    menores++;
                    sumador_edades = sumador_edades + numero;
                    contador_edades++;

                }
            } while (numero > 0);

            float promedio = sumador_edades / contador_edades;
            Console.WriteLine("promedio de edades: " + promedio);
            Console.WriteLine("cantidad de mayores de edad: " +  mayores);
            Console.WriteLine("cantidad de menores de edad: " + menores);
        }
    }
}