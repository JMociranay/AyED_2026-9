using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double midictorianos;
            Console.WriteLine("ingrese la cantidad de midiclorianos detectados en el sujeto: ");
            midictorianos = Convert.ToDouble(Console.ReadLine());
            if (midictorianos > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado.Avisar al Consejo");
            }
            else if (5000 < midictorianos & midictorianos < 15000)
            {
                Console.WriteLine("Aceptable para entrenamiento Padawan");
            }
            else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza");

            }


        }
    }
}
      