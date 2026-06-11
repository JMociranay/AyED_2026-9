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
            int creditos = 100;
            int apuesta;
            int dado1, dado2, suma;

            Console.WriteLine("Comienzas con 100 créditos.");

            do
            {
                Console.WriteLine("\nCréditos actuales: " + creditos);
                Console.Write("Ingrese su apuesta (0 para retirarse): ");
                apuesta = int.Parse(Console.ReadLine());

                if (apuesta < 0 || apuesta > creditos)
                {
                    Console.WriteLine("Apuesta inválida.");
                }
                else if (apuesta == 0)
                {
                    Console.WriteLine("Te retiraste del juego.");
                }
                else
                {
                    Console.Write("Ingrese valor del dado 1 (1-6): ");
                    dado1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese valor del dado 2 (1-6): ");
                    dado2 = int.Parse(Console.ReadLine());

                    suma = dado1 + dado2;

                    if (suma == 7 || suma == 11)
                    {
                        Console.WriteLine("¡Ganaste! ");
                        creditos += apuesta;
                    }
                    else
                    {
                        Console.WriteLine("Perdiste ");
                        creditos -= apuesta;
                    }
                }

            } while (creditos > 0 && apuesta != 0);

            Console.WriteLine("Juego terminado.");
            Console.WriteLine("Saldo final: " + creditos);
        }
    }
}
