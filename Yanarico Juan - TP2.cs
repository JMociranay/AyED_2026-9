using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juan_Yanarico
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string pelicula_favorita;

            Console.WriteLine("hola nuevo usuario");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();         
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula_favorita = Console.ReadLine();
            Console.WriteLine("hola "+ nombre +" Tu pelicula preferida "+ pelicula_favorita +" es una porqueria");
        }
    }
}
