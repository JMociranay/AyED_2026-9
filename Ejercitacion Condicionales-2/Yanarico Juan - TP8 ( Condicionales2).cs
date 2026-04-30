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
            double a, b, c;
            Console.Write("ingrese el primer numero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese el segundo numero: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("ingrese el tercer numero: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("el numero " + a + " es mayor");
                }
                else
                {
                    Console.WriteLine("el numero " + c + " es mayor");
                }
            }
            else if (b > c)
            {
                Console.WriteLine("el numero " + b + " es mayor");
            }
            else
            {
                Console.WriteLine("el numero " + c + " es mayor");
            }
        }
    }
}
