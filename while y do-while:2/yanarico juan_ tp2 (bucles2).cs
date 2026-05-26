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
            int numero_adivinar = 67;
            int numero_intento;
            int contador = 0;

            do
            {
                Console.Write("Adivina el numero: ");
                numero_intento = int.Parse(Console.ReadLine());
                if (numero_intento > numero_adivinar)
                {
                    Console.WriteLine("el numero a adivinar es mennor");
                    contador++;
                }
                else if (numero_intento == numero_adivinar)
                {
                    Console.WriteLine("adivinaste el numero : " + numero_adivinar);
                    contador++;
                }
                else
                {
                    Console.WriteLine("el numero a adivinnar es mayor");
                    contador++;
                }
            } while (numero_intento != numero_adivinar);
            Console.WriteLine("numero de intentos: " + contador);

        }
    }
}
