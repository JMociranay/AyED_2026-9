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
            double mayor = 0;
            double menor = 0;
            double total = 0;
            double[] temperatura = new double[7];
            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.Write("ingrese la temperatura "  +(i + 1) + " :");
                temperatura[i] = Convert.ToDouble(Console.ReadLine());
                total += temperatura[i];
                if (i == 0)
                {
                    mayor = temperatura[i];
                    menor = temperatura[i];
                }
                else
                {
                    if (temperatura[i] > mayor)
                    {
                        mayor = temperatura[i];                
                    }
                    if (temperatura[i] < menor)
                    {
                        menor = temperatura[i];
                    }
                }
            }
            Console.WriteLine("Temperatura más alta: " + mayor);
            Console.WriteLine("Temperatura más baja: " + menor);
            Console.WriteLine("Promedio semanal: " + (total / temperatura.Length));
        }
    }
}
