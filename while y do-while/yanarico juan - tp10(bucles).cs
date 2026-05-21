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
            int resultado = 0;
            int numero1, numero2;
            int contador = 0; 
            Console.Write("ingrese el primer numero positivo: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo numero positivo: ");
            numero2 = int.Parse(Console.ReadLine());

            while (contador < numero2 )
            {
                resultado = resultado + numero1;
                contador++;
            }
            Console.WriteLine("el resultado es " + resultado);
        }
    }
}
