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
            string usuario = "juan";
            string contraseña = "hola1234";
            bool finalizar = true;
            int contador = 0;

            while (finalizar == true && contador < 3)
            {
                Console.Write("ingrese el nombre de usuario: ");
                string intento_nombre = Console.ReadLine();
                Console.Write("ingrese la contraseña: ");
                string intento_contra = Console.ReadLine();

                if (intento_nombre == usuario && intento_contra == contraseña)
                {
                    finalizar = false;
                    contador++;

                }
                else
                {
                    Console.WriteLine("nombre de usuario o contraseña esta mal ,intente de nuevo");
                    contador++;
                }
            }
            if (contador == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
            else
            {
                Console.WriteLine("Bienvenido al sistema");
            }

        }
    }
}
