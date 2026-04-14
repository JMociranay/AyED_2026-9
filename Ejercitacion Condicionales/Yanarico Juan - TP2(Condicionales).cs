using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if ( edad >= 18)
            {
                Console.WriteLine("Bienvenido al club " + nombre);
            }
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
        }
    }
}
