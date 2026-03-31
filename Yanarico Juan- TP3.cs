using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanarico_Juan___TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int año;
            Console.Write("coloque su año de nacimiento: ");
            año = Convert.ToInt32(Console.ReadLine());
            edad = 2026 - año;
            Console.WriteLine("Si naciste en el año" + año + "tu edad al comenzar el año es de " + edad + "años.");

        }
    }
}
