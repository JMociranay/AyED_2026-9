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
            int corredorMayor = 0;
            int corredorMenor = 0;
            double mayor = 0;
            double menor = 0;
            double[] tiempos = new double[6];
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write("ingrese el tiempo del corredor N°" + (i + 1) + ":");
                tiempos[i] = Convert.ToDouble(Console.ReadLine());
                if (i == 0)
                {
                    mayor = tiempos[i];
                    menor = tiempos[i];
                    corredorMayor = i + 1;
                    corredorMenor = i + 1;
                }
                else
                {
                    if (tiempos[i] > mayor)
                    {
                        mayor = tiempos[i];
                        corredorMayor = i + 1;
                    }

                    if (tiempos[i] < menor)
                    {
                        menor = tiempos[i];
                        corredorMenor = i + 1;
                    }
                }
            }
            Console.WriteLine("Mejor tiempo: " + menor + " segundos");
            Console.WriteLine("Ganador: corredor N°" + corredorMenor);

            Console.WriteLine("Peor tiempo: " + mayor + " segundos");
            Console.WriteLine("Corredor N°" + corredorMayor);
        }
    }
}
