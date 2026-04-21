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
            string nombre, contraseña;
            Console.Write("inbgrese un nombre de usuario: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese una contraseña: ");
            contraseña = Console.ReadLine();

            if (nombre == "admin" & contraseña == "1234")
            {
                Console.WriteLine("Acceso Cocedido");

            }
            else
            {
                Console.WriteLine("error de credenciales");
            }
            
        }
    }
}
