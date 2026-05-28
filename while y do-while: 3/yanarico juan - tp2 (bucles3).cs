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
            double porcentaje = 0;
            bool finalizar = true;
            string continuar;
            int contador_presente = 0;
            int contador_ausente = 0;
            int alumnos_totales = 0;
            do
            {
                Console.Write("ingrese el nombre del alumno: ");
                string alumno = Console.ReadLine();
                Console.WriteLine("ingrese su estado presente (P) o ausente (A): ");
                string estado = Console.ReadLine();
                if ((estado == "P") || (estado == "p"))
                {
                    contador_presente++;
                }
                else if ((estado == "A") || (estado == "a"))
                {
                    contador_ausente++;
                }
                alumnos_totales++;
                Console.Write("desa continuar (S/N): ");
                continuar = Console.ReadLine();
                if ((continuar == "N") || (continuar == "n"))
                {
                    finalizar = false;
                }
                else if (continuar != "S" && continuar != "s")
                {
                    Console.WriteLine("opcion no valida");

                }


            }
            while (finalizar == true);
            if (alumnos_totales > 0)
            {
                porcentaje = contador_presente * 100 / alumnos_totales;
            }

            Console.WriteLine("cantidad de presentes: " + contador_presente);
            Console.WriteLine("cantidad de ausentes: " + contador_ausente);
            Console.WriteLine("porcentaje de presentismo: " + porcentaje + "%");
        }
    }
}
