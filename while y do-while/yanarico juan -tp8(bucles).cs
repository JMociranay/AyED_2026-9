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
            int temperatura;
            Console.Write("ingrese una temperatura inicial: ");
            temperatura = int.Parse(Console.ReadLine());

            while (temperatura >= 24)
            {
                temperatura = temperatura - 2;
                Console.WriteLine("enfriando...temperatura actual " + temperatura + "C°");

            }
            Console.WriteLine("´temperatura IDEAL alcanzada.");

        }
    }
}
