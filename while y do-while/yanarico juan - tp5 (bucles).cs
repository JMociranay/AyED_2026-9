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
            string clave;
            string clave_correcta = "pikachu";

            do
            {
                Console.Write("ingrese la clave de texto: ");
                clave = Console.ReadLine();
                if (clave != clave_correcta)
                {
                    Console.WriteLine("clave incorrecta ingrese denuevo");

                }

            }
            while (clave != clave_correcta);
            Console.WriteLine("acceso pernutido");

        }
    }
}
