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
            int total = 0;
            int aprobados = 0;
            int desaprobados = 0;
            int[] notas = new int[10];
            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
                Console.Write("ingrese la nota " + (i + 1) + " : ");
                notas[i] = int.Parse(Console.ReadLine());
                total += notas[i];
                int nota = notas[i];
                if(nota >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }

            }
            double promedio = total / notas.Length;
            Console.WriteLine("aprobaron " + aprobados + " alumnos");
            Console.WriteLine("desaprobaron " + desaprobados + " alumnos");
            Console.WriteLine("el promedio de nota es " + promedio);
        }
    }
}
