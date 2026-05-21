using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir == true)
                {
                Console.WriteLine("MENU SIMPLE");
                Console.WriteLine("1. SALUDAR");
                Console.WriteLine("2. DESPEDIRSE");
                Console.WriteLine("3. SALIR");
                Console.WriteLine(" seleccione una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("elegiste saludarlo, -te devuelve el saludo-");
                        break;
                    case 2:
                        Console.WriteLine("elegiste despedirte, -extrañado se despide-");
                        break;
                    case 3:
                        Console.WriteLine("saliendo del programa");
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }

            }
           

        }
    }
}
