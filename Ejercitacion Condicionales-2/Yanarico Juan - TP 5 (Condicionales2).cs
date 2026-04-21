using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos;
            Console.Write("ingrse una cantidad de segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());
            if ( segundos >= 60)
            {
                minutos = segundos / 60;
                segundos = segundos % 60;
                Console.WriteLine("minutos :" + minutos + ", segundos: " + segundos);

            }
            else
            {
                Console.WriteLine("segundos: " + segundos);
            }
        }
    }
}
