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
            int menor = 0;
            int mayor = 0;
            int intermedio = 0;
            int[] edades = new int[12];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("ingrese la edad de la persona " + (i + 1) + " : ");
                edades[i] = int.Parse(Console.ReadLine());
                if (edades[i] < 18)
                {
                    menor++;
                }
                else if(edades[i] >= 65)
                {
                    mayor++;
                }
                else
                {
                    intermedio++;
                }
            }
            Console.WriteLine("menores de edad: "+ menor);
            Console.WriteLine("mayores de edad: "+ mayor);
            Console.WriteLine("intermedios de edad: "+ intermedio);

        }
    }
}
