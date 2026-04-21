using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            Console.WriteLine("que tipo de triangulo es");
            Console.Write("ingrese el lado 1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese el lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese el lado 3: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2 & lado1 == lado3)
            {
                Console.WriteLine("su triangulo es Equilatero ");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("su triangulo es Isosceles");
            }
            else
            {
                Console.WriteLine("su triangulo es Escaleno");
            }

        }
    }
}
