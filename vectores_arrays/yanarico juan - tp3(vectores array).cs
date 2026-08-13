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
            int ausencias = 0;
            int dias = 0;
            string[] clases = new string[20];
            for (int i = 0; i < clases.Length; i++)
            {
                dias++;
                Console.Write("ingrese si tuvo asistencia el dia " + dias + " (presente = p)(ausente = a): ");
                clases[i] = Console.ReadLine();
                string asistencia = clases[i];
                if ((asistencia == "A") || (asistencia == "a"))
                {
                    ausencias++;
                }
            }
            if (ausencias > 6)
            {
                Console.WriteLine("alumno libre con "+ ausencias +" ausencias");
            }
            else
            {
                Console.WriteLine("alumno regular con "+ ausencias + " ausencias" );
            }
        }
    }
}
