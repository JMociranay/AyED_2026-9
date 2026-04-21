using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura;
            Console.Write("ingrese la temperatura: ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("alerta de frio extremo");
            }
            else if (temperatura > 0 & temperatura <= 15)
            {
                Console.WriteLine("mucho frio");

            }
            else if (temperatura > 15)
            {
                Console.WriteLine("crima agradable");
            }
        }
    }
}
