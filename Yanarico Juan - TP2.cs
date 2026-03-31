using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yanarico_Juan___TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string juego_favorito;
            string nombre;
            string consola;
            Console.WriteLine("hola usuario");
            Console.Write("¿cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            juego_favorito = Console.ReadLine();
            Console.Write("¿en que consola se juega?: ");
            consola = Console.ReadLine();
            Console.WriteLine("hola "+  nombre + " tu juego favorito es "+ juego_favorito+ " y se juega en "+ consola);




        }
    }
}
